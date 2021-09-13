using System;

namespace Belajar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULATOR WITH ME ===\n");

            double input = 0;
            double input2 = 0;
            string ope = "";
            double value = 0;

            Console.Write("Input first number = ");
            input = double.Parse(Console.ReadLine());
            Console.Write("Input operator = ");
            ope = Console.ReadLine();
            Console.Write("Input second number = ");
            input2 = double.Parse(Console.ReadLine());
            

            if (ope == "+")
            {
                value = input + input2;
            } 
            else if (ope == "-")
            {
                value = input - input2;
            }
            else if (ope == "*")
            {
                value = input * input2;
            }
            else if (ope == "/")
            {
                value = input / input2;
            }
            else if (ope != "+")
            {
                Console.WriteLine("Operator tidak sesuai!");

            }
            Console.Write("Value = ");
            Console.Write(value);
        }
    }
}
