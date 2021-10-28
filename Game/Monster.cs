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
            return "Монстр " + name + " сила: " + power + " здоровье: " + heals;
        }

        public void Passport()
        {
            Console.WriteLine(this.ToString());
        }

        public void Attack(object B)
        {
            if(this.power > ((Monster)B).power)
            {
                ((Monster)B).heals -= this.power;
                this.power += 10;
            }
            if(this.power < ((Monster)B).power)
            {
                this.heals -= ((Monster)B).power;
                ((Monster)B).power += 10;

            }
        }

        public bool Diw()
        {
            if (this.heals <=0 )
            {
                Console.WriteLine("Монстр "+ name + " умер...");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
