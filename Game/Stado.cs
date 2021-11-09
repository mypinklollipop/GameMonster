using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Stado
    {
        Monster[] stado = new Monster[5];
        int size;

        public Stado()
        {
            size = 0;
        }

        public int Size
        {
            get { return size; }
        }
        public void Add(Monster M)
        {
            int n = this.size;
            if (n < 5)
            {
                stado[n] = M;
                size++;
            }
        }
        public void Remove()
        {
            Monster[] temp = new Monster[5];
            int k = 0;
            for (int i = 0; i<size; i++)
            {
                if (!stado[i].Die())
                {
                    temp[k] = stado[i];
                    k++;
                }
            }
            stado = temp;
            size = k;
        }

        public void Game(Monster V)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Сражение " + i+ " началось!");
                Console.WriteLine("Сражается монстр " + V.Name + " с монстром " + stado[i].Name);
                V.Attack(stado[i]);
                V.Passport();
                stado[i].Passport();
                if (V.Die())
                {
                    Console.WriteLine("Игра окончена! Вы проиграли!");
                    break;
                }
            }
        }
    }
}
