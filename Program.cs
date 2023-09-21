using System;
namespace prog16092023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 2 глава \n Упражнение 2.1 ");
            
            Console.WriteLine("ВВедите имя пользователя:");

            string name = Console.ReadLine();
            Console.WriteLine($" \nПривет {name}, хорошего дня тебе! \n");

            Console.WriteLine("Лабораторная работа 2 глава \n Упражнение 2.2 ");

            Console.WriteLine("Введите первое число:");
            string num1 = Console.ReadLine();
            double n1 = Convert.ToDouble(num1);

            Console.WriteLine("Введите второе число:");
            string num2 = Console.ReadLine();
            double n2 = Convert.ToDouble(num2);

            if (n2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя. \n Введите 2 число снова: \n ");
                num2 = Console.ReadLine();
                n2 = Convert.ToDouble(num2);
                while (n2 == 0)
                {
                    Console.WriteLine("На ноль делить нельзя.\n Введите 2 число снова: \n"); 

                    num2 = Console.ReadLine();
                    n2 = Convert.ToDouble(num2);
                }
                Console.WriteLine($"Результатом деления данных чисел будет {n1 / n2}");
            }
            else
            {
                Console.WriteLine($"Результатом деления данных чисел будет {n1 / n2}");
            }

            Console.WriteLine("Д/З 2.1: Вывести след. букву");
            Console.Write("Введите букву англ. алфавита: ");
            char num3 = char.Parse(Console.ReadLine());
            if (num3=='z')
            {
                Console.WriteLine(num3 + " последняя буква,введите другую");
            }
            else
            {
                num3++;
                Console.WriteLine("Следующая буква: " + num3);
            }

            Console.WriteLine("Задание 5. Программа находит корни квадратного уравнения");
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());
            double discrim = Math.Pow(b, 2) - 4 * a * c;
            if (discrim < 0)
            {
                Console.WriteLine("Не имеет корней");
            }
            else
            {
                double x1 = ((-b + Math.Sqrt(discrim)) / (a * 2));
                double x2 = ((-b - Math.Sqrt(discrim))/ (a * 2));
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }

            
        }
    }
}
