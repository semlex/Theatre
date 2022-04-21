using System;

namespace Theatre
{
    class Performance : IShow
    {
        private string name; // Название представления
        private DateTime time; // Время представления
        private Hall hall; // Зал, в котором проходит представление
        private int minPrice; // Минимальная стоимость билета
        public Performance(string _name, DateTime _time, int _hallNum, int _price)
        {
            name = _name;
            time = _time;
            hall = new Hall(_hallNum, _price);
            minPrice = _price;
        }
        public string Name // Получить название представления
        {
            get { return name; }
        }
        public DateTime Time // Получить время представлнения
        {
            get { return time; }
        }
        public Hall Hall // Получить зал, в котром проходит представление
        {
            get { return hall; }
        }
        public int MinPrice // Получить минимальную стоимость билета
        {
            get { return minPrice; }
        }
        public void show() // Вывод на консоль
        {
            Console.WriteLine("{0} \"{1}\" зал {2} от {3} рублей", time, name, hall.HallNumber, minPrice);
        }
    }
}
