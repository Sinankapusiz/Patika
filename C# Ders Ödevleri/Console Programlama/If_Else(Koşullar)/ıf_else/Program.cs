using System;

namespace ıf_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time <= 11)
                Console.WriteLine("Günaydın!");
            else if (time <= 18)
                Console.WriteLine("İyi Günler!");
            else
                Console.WriteLine("iyi Geceler!");

            string sonuc = time <= 18 ? "İyi günler" : "İyi geceler";

            sonuc = time >= 6 && time < 11 ? "Günaydın!" : time <= 18 ? "İyi Günler" : "İyi Geceler!";
            Console.WriteLine(sonuc);
        }
    }
}
