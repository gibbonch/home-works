using System;

namespace MusicDiscStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //change parametrs
            Store store = new Store("Disc Store", "Moscow, Russia");
            Audio audio1 = new Audio("artist 1", "studio 1", 10, "audio disc 1", "genre 1");
            Audio audio2 = new Audio("artist 2", "studio 2", 15, "audio disc 2", "genre 2");
            Audio audio3 = new Audio("artist 3", "studio 3", 20, "audio disc 3", "genre 3");
            DVD dvd1 = new DVD("producer 1", "company 1", 1200, "dvd disc 1", "film genre 1");
            DVD dvd2 = new DVD("producer 2", "company 2", 1400, "dvd disc 2", "film genre 2");
            DVD dvd3 = new DVD("producer 3", "company 3", 1600, "dvd disc 3", "film genre 3");

            store = store + audio1 + audio2 + audio3;
            store = store + dvd1 + dvd2 + dvd3;

            Console.WriteLine(store.ToString());

            audio2.Burn("somename", "somegenre", "someartist", "somestudio", "100");
            Console.WriteLine(audio2.ToString());

            Console.WriteLine(store.PrintSizes());

            Console.ReadKey();
        }
    }
}