using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Demon:Monster
    {
        private int brain; // Ум.

        public Demon(string name, int power, int heals, int brain) : base(name, power, heals)
        {
            this.brain = brain;
        }

        public Demon(string name) : base(name)
        {
            this.brain = rnd.Next(1, 6);
        }

        public override string ToString()
        {
            return base.ToString() + " ум: " + brain;
        }

        public int Brain
        {
            get
            {
                return brain;
            }
        }
    }
}
