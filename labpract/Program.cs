using System;

namespace labpract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine($"byte - max: {byte.MaxValue},min: {byte.MinValue} \nsbyte - max: {sbyte.MaxValue}, min: {sbyte.MinValue} \n" +
            $"short - max: {short.MaxValue}, min: {short.MinValue} \nushort - max: {ushort.MaxValue}, min: {ushort.MinValue} \n" +
            $"int - max: {int.MaxValue}, min: {int.MinValue} \nuint - max: {uint.MaxValue}, min: {uint.MinValue} \n" +
            $"long - max: {long.MaxValue}, min: {long.MinValue} \nulong - max: {ulong.MaxValue}, min: {ulong.MinValue} \n" +
            $"float - max: {float.MaxValue}, min: {float.MinValue} \ndouble - max: {double.MaxValue}, min: {double.MinValue} \n" +
            $"decimal - max: {decimal.MaxValue}, min: {decimal.MinValue} \nchar - max: нет, min: нет \nbool - max: нет, min: нет \nstring - max: нет, min: нет \nobject - max: нет, min: нет");
            
            
            Console.WriteLine("Задание 2");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();
            Console.Write("Введите PIN-код: ");
            int PIN = int.Parse(Console.ReadLine());
            (string, int, string, int) person = (name, age, city, PIN);
            Console.WriteLine($"Пользователю {person.Item1} {person.Item2} лет, проживает в городе {person.Item3}, имеет PIN-код {person.Item4}");
        }
    }
}