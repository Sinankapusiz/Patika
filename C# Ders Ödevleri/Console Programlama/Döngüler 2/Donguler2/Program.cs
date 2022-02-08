using System;

namespace Donguler2
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program.
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam=0;
            while (sayac<= sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            //'a' dan 'z' ye kadar tüm harfleri console yazdır.

            char character='a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("***** Foreach *****");
            string[] arabalar ={"BMW","FORD","TOYOTA","NİSSAN"};
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
