using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number:");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teine number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vali tehe ('+', '-', '*' või '/')");
            char useroperation = Convert.ToChar(Console.ReadLine());

            switch (useroperation)
            {
                case '+':
                    AddTwoNumbers(firstnumber, secondnumber);
                    break;
                case '/':
                    DivideTwoNumber(firstnumber, secondnumber);
                    break;
                case '*':
                    MultiplyTwoNumbers(firstnumber, secondnumber);
                    break;
                case '-':
                    SubtractTwoNumbers(firstnumber, secondnumber);
                    break;
                default:
                    Console.WriteLine("vale tehe");
                    break;
                
            }


            
        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
        }
        private static void DivideTwoNumber(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
        }
        private static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
        }
        private static void SubtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
        }

    }
}
