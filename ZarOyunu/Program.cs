using System;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            TavlaZari tavlaZari1 = new TavlaZari(6);
            TavlaZari tavlaZari2 = new TavlaZari(6);
            Console.WriteLine("1. Zar: " + tavlaZari1.ZarAt());
            Console.WriteLine("2. Zar: " + tavlaZari2.ZarAt());
            
        }
    }
}
