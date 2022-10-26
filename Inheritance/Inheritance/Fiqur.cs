using System;

namespace Inheritance
{
    public class Fiqur : ikiboyut
    {
        public string Stil { get; set; }

        public void StilGoster()
        {
            Console.WriteLine("Stil : "+Stil);
        }

        public double Sahesi()
        {
            return A*H/ 2;
        }
    }
}