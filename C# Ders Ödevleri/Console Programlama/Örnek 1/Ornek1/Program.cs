using System;

namespace Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen isminizi giriniz : "); //.WriteLine yerine .Write yazılma nedeni: mesaj ile girişin tek satırda olmasını istemem.
            string isim = Console.ReadLine();
            Console.Write("Lütfen Soyisminizi giriniz : ");
            string soyIsim = Console.ReadLine();
            Console.WriteLine("PatikaDev Hoşgeldin {0} {1}",isim,soyIsim);
        }
    }
}
