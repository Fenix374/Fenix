using System;

class Calculator
{
    static void Main()
    {
        int choice;
        double num1, num2, result;

        while (true)
        {
            Console.WriteLine("Выбери что не умеешь делать:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выйти из программы");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 9)
            {
                break;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine("Вот чё вышло: " + result);
                    break;
                case 2:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine("Вот чё вышло: " + result);
                    break;
                case 3:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine("Вот чё вышло: " + result);
                    break;
                case 4:
                    Console.WriteLine("Введите первое число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 / num2;
                    Console.WriteLine("Вот чё вышло: " + result);
                    break;
                case 5:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень:");
                    int power = Convert.ToInt32(Console.ReadLine());
                    result = Math.Pow(num1, power);
                    Console.WriteLine("Вот чё вышло: " + result);
                    break;
                case 6:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Sqrt(num1);
                    Console.WriteLine("Вот чё вышло: " + result);
                    break;
                case 7:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = num1 / 100;
                    Console.WriteLine("Вот чё вышло: " + result);
                    break;
                case 8:
                    Console.WriteLine("Введите число:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = Factorial(num1);
                    Console.WriteLine("Вот чё вышло: " + result);
                    break;
                default:
                    Console.WriteLine("Давай по новой чёт не работает!");
                    break;
            }
        }
    }

    static double Factorial(double num)
    {
        double result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }
}