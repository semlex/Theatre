using System;
using System.Collections.Generic;

namespace Theatre
{
    abstract class Zone : IShow // Абстрактный класс зоны зрительного зала
    {
        protected string name; // Название зоны
        protected double price; // Стоимость билета в этой зоне
        protected int quantityRows; // Количество рядов в зоне
        protected int quantitySeats; // Количество мест в каждом ряду
        protected int freeSeats; // Свободные места в зоне
        protected List<Seat> places = new List<Seat>(); // Список мест
        public Zone(string _name, int _qR, int _qS, double _price)
        {
            name = _name;
            price = _price;
            quantityRows = _qR;
            quantitySeats = _qS;
            freeSeats = _qR * _qS;
            for (int i = 0; i < _qR; i++)
            {
                for (int j = 0; j < _qS; j++)
                {
                    places.Add(new Seat(i + 1, j + 1));
                }
            }
        }
        public string Name // Получить название зоны
        {
            get { return name; }
        }
        public int QuantityRows // Получить количество рядов в зоне
        {
            get { return quantityRows; }
        }
        public int QuantitySeats // Получить количество мест в каждом ряду
        {
            get { return quantitySeats; }
        }
        public int FreeSeats // Получить свободные места
        {
            get { return freeSeats; }
        }
        public void show() // Вывести информацию о зоне на консоль
        {
            Console.WriteLine("{0} свободных мест {1} рублей за место {2} рядов {3} мест в ряду",
                freeSeats, price, quantityRows, quantitySeats);
        }
        public bool freeSeat(int i, int j) // Выяснить, свободно ли место в i-ом ряду на j-ом месте
        {
            return places.Find(x => x.Row == i && x.SeatNum == j).Status == "free";
        }
        public void buy(int i, int j) // Купить место в i-ом ряду на j-ом месте
        {
            freeSeats--;
            places.Find(x => x.Row == i && x.SeatNum == j).setStatus("sold");
        }
    }
}
