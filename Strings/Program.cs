﻿namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Strings");

            string city = "Kocaeli";
            // string bir char arrayidir.
            // Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            string result = city + city2;
            //Console.WriteLine(result);
            Console.WriteLine(String.Format("{0},{1}", city,city2));
        }
    }
}