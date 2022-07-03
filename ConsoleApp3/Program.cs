using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            double one, two, three;

            try//не совсем понимаю как это работает, но с помощью этого удается провести проверку на ввод чисел
            {
                Console.WriteLine("Введите первое число:");
                one = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                two = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите третье число:");
                three = double.Parse(Console.ReadLine());

                result = one + two + three;
                Console.WriteLine("Сумма чисел:" + result);

                result = (one + two + three) / 3;
                Console.WriteLine("Среднее арифмитическое чисел:" + result);

                result = one * two * three;
                Console.WriteLine("Произведение чисел:" + result);
            }
            catch
            {
                Console.WriteLine("Некорректный ввод!");
            }

        }
    }
}

