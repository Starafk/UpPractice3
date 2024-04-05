using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");

        int choice = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                break;
            case 2:
                result = Substract(num1, num2);
                break;
            case 3:
                result = Multiply(num1, num2);
                break;
            default:
                Console.WriteLine("Неверно выбрана операция");
                break;
        }

        Console.WriteLine("Результат: " + result);
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Substract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }
