using System;

namespace Theatre
{
    class Theatre
    {
        static void Main()
        {
            Performance[] performances = {
                new Performance("Ревизор", new DateTime(2021, 5, 23, 18, 0, 0), 1, 500),
                new Performance("Фальшивая нота", new DateTime(2021, 5, 24, 19, 0, 0), 1, 600),
                new Performance("Бунин. Он, она...", new DateTime(2021, 5, 24, 19, 30, 0), 2, 1500)};
            Affiche affiche = new Affiche(performances);
            BoxOffice boxOffice = new BoxOffice();
            boxOffice.buyTicket(affiche);
            boxOffice.buyTicket(affiche);
            string s1 = "1";
            string s2 = "2";
            if (Object.ReferenceEquals(s1, s2)) 
                Console.WriteLine("Equals");
        }
    }
}