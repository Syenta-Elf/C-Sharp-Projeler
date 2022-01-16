using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlanHesaplama
{
    public class Daire : Sekiller
    {
        
        public Daire(int x)
        {
            this.x = x;
            _alan = Math.PI*x*x;
            menu();
        }

        public override void alan()
        {
            System.Console.WriteLine("Alan:"+_alan);
        }

        public override void cevre()
        {
            System.Console.WriteLine("Çevre:"+(Math.PI*this.x*2));
        }

        public override void hacim()
        {
            System.Console.WriteLine("Hacim:"+_alan*this.x*(4.0/3.0));
        }
    }
}