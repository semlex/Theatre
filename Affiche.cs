using System;
using System.Collections.Generic;

namespace Theatre
{
    class Affiche : IShow // Афиша театра
    {
        private List<Performance> performances = new List<Performance>(); // Список представлений
        public Affiche(Performance[] _performances)
        {
            foreach (Performance _perfomance in _performances)
            {
                performances.Add(_perfomance);
            }
        }
        public List<Performance> Performances // Получить список представлений
        {
            get { return performances; }
        }
        public void show() // Вывод на консоль
        {
            int i = 1;
            Console.WriteLine("Текущая афиша в театре: ");
            performances.ForEach(delegate (Performance performance)
            {
                Console.Write("{0}) ", i);
                performance.show();
                i++;
            });
        }
    }
}