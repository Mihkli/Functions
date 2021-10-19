using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma nimi:");
            string username = Console.ReadLine();
            Console.WriteLine("Sisesta oma vanus:");
            int userage = Convert.ToInt32(Console.ReadLine());

            sayhello(username, userage);
        }

        private static void sayhello(string somename, int somenumber)
        {
            Console.WriteLine($"Hi there! {somename}");
            Console.WriteLine($"Oled sündinud aastal {2021 - somenumber}.");

        }
    }
}
