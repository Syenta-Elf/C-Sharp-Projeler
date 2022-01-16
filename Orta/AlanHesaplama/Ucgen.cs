using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Ucgen : Sekiller
    {
        
        public Ucgen(int x)
        {
            this.x = x;
            _alan = (Math.Sqrt(3)/4)*(this.x*this.x);
            menu();
        }
        public override void alan()
        {
            System.Console.WriteLine("Alan:"+_alan);
        }

        public override void cevre()
        {
            System.Console.WriteLine("Cevre:"+(3*this.x));
        }

        public override void hacim()
        {
            int h = yukseklik();            
            System.Console.WriteLine("Hacim:"+(0.33333333)*_alan*h);
        }
    }
}