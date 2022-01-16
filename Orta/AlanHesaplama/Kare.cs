using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Kare : Sekiller
    {
        public Kare(int x)
        {
            this.x = x;
            _alan = this.x*this.x;
            menu();
        }

        public override void alan()
        {
            System.Console.WriteLine("Alan:"+(this.x*this.x));
        }

        public override void cevre()
        {
            System.Console.WriteLine("Cevre:"+(this.x*4));
        }

        public override void hacim()
        {        
            int h = yukseklik();
            System.Console.WriteLine("Hacim"+_alan*h);
        }

    }
}