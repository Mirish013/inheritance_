using System;

namespace Inheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ikiboyut iki = new ikiboyut();
            iki.A = 10;
            iki.H = 20;
            iki.Goster();
            
            Fiqur Ucbucaq = new Fiqur();
            Ucbucaq.A = 5;
            Ucbucaq.H = 6;
            Ucbucaq.Stil = "UCBUCAQ";
            Ucbucaq.StilGoster();
            Console.WriteLine("Sahe : "+Ucbucaq.Sahesi());

        }
    }
}