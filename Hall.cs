using System.Collections.Generic;

namespace Theatre
{
    class Hall // Класс зрительного зала
    {
        private int hallNumber; // Номер зала
        private List<Zone> zones = new List<Zone>(); // Список зон зала
        public Hall(int _hallNumber, int _price)
        {
            hallNumber = _hallNumber;
            zones.Add(new Stalls(7, 22, 2 * _price));
            zones.Add(new Benoir(3, 10, 2.5 * _price));
            zones.Add(new DressCircle(9, 25, 1.5 * _price));
            zones.Add(new Balcony(12, 30, _price));
        }
        public int HallNumber // Получить номер зала
        {
            get { return hallNumber; }
        }
        public Zone getZone(string _name) // Получить зону зрительного зала
        {
            return zones.Find(x => x.Name == _name);
        }
    }
}
