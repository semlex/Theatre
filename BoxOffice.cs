using System;

namespace Theatre
{
    class BoxOffice : IBoxOffice
    {
        private int choosePerformance(Affiche affiche) // Выбрать представление
        {
            affiche.show(); // Показ афиши
            int performanceNum;
            while (true)
            {
                Console.Write("Выберите выступление: ");
                performanceNum = Convert.ToInt32(Console.ReadLine());
                if (performanceNum <= affiche.Performances.Count && performanceNum > 0) break;
            }
            return performanceNum;
        }
        private string chooseZone() // Выбрать зону зрительного зала
        {
            string zoneName;
            while (true)
            {
                Console.Write("Выберите зону (партер, бенуар, бельэтаж, балкон): ");
                zoneName = Console.ReadLine();
                zoneName = zoneName.ToLower();
                switch (zoneName)
                {
                    case "партер":
                        zoneName = "Stalls";
                        break;
                    case "бенуар":
                        zoneName = "Benoir";
                        break;
                    case "бельэтаж":
                        zoneName = "DressCircle";
                        break;
                    case "балкон":
                        zoneName = "Balcony";
                        break;
                    default:
                        zoneName = "error";
                        break;
                }
                if (zoneName != "error") break;
            }
            return zoneName;
        }
        private int chooseRow(Zone zone) // Выбрать ряд
        {
            int row;
            while (true)
            {
                Console.Write("Выберите ряд: ");
                row = Convert.ToInt32(Console.ReadLine());
                if (row <= zone.QuantityRows && row > 0) break;
            }
            return row;
        }
        private int chooseSeat(Zone zone) // Выбрать место в ряду
        {
            int seat;
            while (true)
            {
                Console.Write("Выберите место: ");
                seat = Convert.ToInt32(Console.ReadLine());
                if (seat <= zone.QuantitySeats && seat > 0) break;
            }
            return seat;
        }
        private void buySeat(Zone zone) // Купить место
        {
            while (true)
            {
                int row = chooseRow(zone);
                int seat = chooseSeat(zone);
                if (zone.freeSeat(row, seat)) // Проверка занято ли место
                {
                    zone.buy(row, seat); // Если нет - билет будет продан
                    Console.WriteLine("Билет успешно продан\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Место уже занято. Выберите другое"); // Если занято - будет предложено выбрать другое
                }
            }
        }
        public void buyTicket(Affiche affiche) // Покупка билета
        {
            int performanceNum = choosePerformance(affiche);
            Performance performance = (affiche.Performances)[performanceNum - 1];
            string zoneName = chooseZone();
            Zone zone = performance.Hall.getZone(zoneName);
            zone.show();
            buySeat(zone);
        }
    }
}
