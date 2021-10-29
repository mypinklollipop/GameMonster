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
            Monster M1 = new Monster("Вася", 65, 300);
            Demon D1 = new Demon("Маша");
            M1.Passport();
            D1.Passport();
            Console.WriteLine("Сражение началось!");
            Console.WriteLine("Сражается монстр " + M1.Name + " с монстром " + D1.Name);
            M1.Attack(D1);
            M1.Passport();
            D1.Passport();


            Console.ReadKey();
        }
    }
}
