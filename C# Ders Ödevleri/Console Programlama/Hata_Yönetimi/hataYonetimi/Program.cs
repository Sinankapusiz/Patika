using System;

namespace hataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.Write("Bir Sayı giriniz : ");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Girmiş olduğunuz sayi : " + sayi);
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("Hata: "+ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("İşlem Tamamlandı.");
            // }

            try
            {
                //int a=int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2000000000000000");
                int b = 25;
                Console.WriteLine(b);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            // catch (FormatException ex)
            // {
            //     Console.WriteLine("Veri tipi uygun değil.");
            //     Console.WriteLine(ex);
            // }
            // catch (OverflowException ex)
            // {
            //     Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
            //     Console.WriteLine(ex);
            // }

        }
    }
}
