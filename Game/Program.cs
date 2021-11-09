using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster Vasya = new Monster("Вася");
            Stado S = new Stado();

            S.Add(new Demon("Маша"));
            S.Add(new Monster("Дракон"));
            S.Add(new Demon("Халк"));

            Vasya.Passport();
            do
            {
                Console.WriteLine("СЕАНС ИГРЫ");
                S.Game(Vasya);
                S.Remove();
            } while (S.Size > 0 && !Vasya.Die());
            S.Game(Vasya);

            Console.ReadKey();
        }
    }
}
