using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3bcv
{
    class Classdrob
    {
        int chislitel;
        int znaminatel;
        public Classdrob(int chislitel, int znaminatel)
        {
            this.chislitel = chislitel;
            this.znaminatel = znaminatel;
        }
        public Classdrob(int chislo)
        {
            this.chislitel = chislo;
            this.znaminatel = 1;
        }
        public Classdrob(int celoe, int chislitel, int znamenatel)
        {
            this.chislitel = celoe * znamenatel + chislitel;
            this.znaminatel = znamenatel;
        }
        public double ToDouble()
        {
            return (Double)(this.chislitel) / this.znaminatel;


        }
        public static Classdrob operator *(Classdrob one, Classdrob two)
        {
            return new Classdrob(one.chislitel * two.chislitel, one.znaminatel * two.znaminatel);

        }
        public bool Znak
        {
            get 
            {
                bool a = chislitel >= 0;
                bool b = znaminatel >= 0;
                return a == b;
                
            }
            public delegate void pofi(Classdrob ofd, int znah); 
        }

    }
}