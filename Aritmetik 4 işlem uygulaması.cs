https://gelecegiyazanlar.turkcell.com.tr/konu/egitim/c-ile-algoritma-ve-programlama-101/aritmetik-4-islem-uygulamasi


using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, toplam,carpım, bolum, fark ;

            Console.WriteLine("***** Aritmetik İşlemler *****");
            
            Console.WriteLine();
            s1 = 20;
            s2 = 5;
            toplam = s1 + s2;
            fark = s1 - s2;
            carpım = s1 * s2;
            bolum = s1 / s2;

            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Fark: " + fark);
            Console.WriteLine("Carpım: " + carpım);
            Console.WriteLine("Bolum: " + bolum);
            
            Console.WriteLine();

            
            Console.WriteLine("***** Aritmetik İşlemler *****");

            Console.Read();


        }
    }
}
