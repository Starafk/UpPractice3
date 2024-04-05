using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("������� ������ �����:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("������� ������ �����:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("�������� ��������:");
        Console.WriteLine("1. ��������");
        Console.WriteLine("2. ���������");
        Console.WriteLine("3. ���������");
        Console.WriteLine("4. �������");

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
                Console.WriteLine("������� ������� ��������");
                break;
        }

        Console.WriteLine("���������: " + result);
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
