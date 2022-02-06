using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch(month)
            {
                case 1: Console.WriteLine("Ocak Ayındasın");break;
                case 2: Console.WriteLine("Şubat Ayındasın");break;
                case 3: Console.WriteLine("Mart Ayındasın");break;
                case 4: Console.WriteLine("Nisan Ayındasın");break;
                case 5: Console.WriteLine("Mayıs Ayındasın");break;
                case 6: Console.WriteLine("Haziran Ayındasın");break;
                case 7: Console.WriteLine("Temmuz Ayındasın");break;
                case 8: Console.WriteLine("Ağustos Ayındasın");break;
                case 9: Console.WriteLine("Eylül Ayındasın");break;
                case 10: Console.WriteLine("Ekim Ayındasın");break;
                case 11: Console.WriteLine("Kasım Ayındasın");break;
                case 12: Console.WriteLine("Aralık Ayındasın");break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2: Console.WriteLine("Kış ayındasınız");break;
                case 3:
                case 4:
                case 5: Console.WriteLine("İlkbahar ayındasınız");break;
                case 6:
                case 7:
                case 8: Console.WriteLine("Yaz ayındasınız");break;
                case 9:
                case 10:
                case 11: Console.WriteLine("Sonbahar ayındasınız");break;
                default:
                break;
            }
        }
    }
}
