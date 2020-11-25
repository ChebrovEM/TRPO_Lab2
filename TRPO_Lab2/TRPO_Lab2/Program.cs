using System;

namespace TRPO_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первый операнд");
            double o1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите знак операции");
            string op = Console.ReadLine();
            if (op != "+" && op != "-" && op != "*" && op != "/") { Console.WriteLine("Неверный оператор!"); return; }
            Console.WriteLine("Введите второй операнд");
            double o2 = Convert.ToDouble(Console.ReadLine());
            double res = 0;
            switch (op)
            {
                case "+":
                    res = o1 + o2;
                    break;
                case "-":
                    res = o1 - o2;
                    break;
                case "*":
                    res = o1 * o2;
                    break;
                case "/":
                    res = o1 / o2;
                    break;
            }
            Console.WriteLine($"{o1}{op}{o2}={res}");
        }
    }
}
