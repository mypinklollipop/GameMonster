using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster
    {
        private string name; // Имя.
        private int power; // Сила.
        private int heals; // Здоровье.

        protected static Random rnd = new Random();

        public Monster(string name, int power, int heals) // Конструктор класса.
        {
            this.name = name;
            this.power = power;
            this.heals = heals;
        }

        public Monster(string name)
        {
            this.name = name;
            this.power = rnd.Next(1, 101);
            this.heals = rnd.Next(100, 1000);
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ": " + name + " сила: " + power + " здоровье: " + heals;
        }

        public void Passport()
        {
            Console.WriteLine(this.ToString());
        }

        public void Attack(object B)
        {
            int b1 = 1, b2 = 1;
            if (this is Demon)
                b1 = ((Demon)this).Brain;
            if (B is Demon)
                b2 = ((Demon)B).Brain;

            if(this.power > ((Monster)B).power)
            {
                ((Monster)B).heals -= this.power/b2;
                this.power += 10;
                Console.WriteLine("Победил " + this.name);
            }
            else
            if (this.power < ((Monster)B).power)
            {
                this.heals -= ((Monster)B).power / b1;
                ((Monster)B).power += 10;
                Console.WriteLine("Победил " + ((Monster)B).name);
            }
            else
                Console.WriteLine("Ничья!");
            Console.WriteLine();
        }

        public bool Die()
        {
            if (this.heals <=0 )
            {
                Console.WriteLine(base.ToString() + ": " + name + " умер...");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
