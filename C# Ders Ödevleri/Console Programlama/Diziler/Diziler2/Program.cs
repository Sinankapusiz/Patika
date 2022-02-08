using System;

namespace Diziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine(" Sıralı Dizi");
            foreach (var sayi in sayiDizi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine(" Sıralı Dizi");
            Array.Sort(sayiDizi);

            foreach (var sayi in sayiDizi)
            {
                Console.WriteLine(sayi);
            }

            //Clear
            Console.WriteLine("****** Array Clear ******");
            // sayiDizisi elemanların kullanarak 2.index ten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizi, 2, 2);

            foreach (var sayi in sayiDizi)
            {
                Console.WriteLine(sayi);
            }
            //Reverse
            Console.WriteLine("****** Array Reverse ******");
            Array.Reverse(sayiDizi);

            foreach (var sayi in sayiDizi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf
            Console.WriteLine("****** Array IndexOf ******");
            Console.WriteLine(Array.IndexOf(sayiDizi, 23));

            //Resize
            Console.WriteLine("****** Array Resize ******");
            Array.Resize<int>(ref sayiDizi, 9);
            sayiDizi[8] = 99;
            
            foreach (var sayi in sayiDizi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}
