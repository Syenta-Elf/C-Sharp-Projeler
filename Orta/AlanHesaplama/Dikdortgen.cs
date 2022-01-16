using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Dikdortgen : Sekiller
    {
        int y;
        public Dikdortgen(int x,int y)
        {
            this.x = x;
            this.y = y;
            _alan = this.x*this.y;
            menu();
        }

        public override void alan()
        {
            System.Console.WriteLine("Alan:"+_alan);
        }

        public override void cevre()
        {
            System.Console.WriteLine("Cevre:"+((x+y)*2));
        }

        public override void hacim()
        {
            int h = yukseklik();
            System.Console.WriteLine("Hacim:"+_alan*h);
        }
    }
}