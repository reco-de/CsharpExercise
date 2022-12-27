using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplama İşleminin Sonucu: " + Toplama(3, 5));
            Console.WriteLine("Çıkarma İşleminin Sonucu: " + Cikarma(20, 5));
            Console.WriteLine("Çarpma İşleminin Sonucu: " + Carpma(3, 5));
            Console.WriteLine("Bölme İşleminin Sonucu: " + Bolme(31, 5));
        }
        //Toplama İşlemi
        static int Toplama(int sayi1 ,int sayi2)
        {
            return sayi1 + sayi2;
        }
        //Çıkarma İşlemi
        static int Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        //Çarpma İşlemi
        static int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        //Bölme İşlemi
        static float Bolme(float sayi1, float sayi2)
        {
            return sayi1 / sayi2;
        }
    }
}
