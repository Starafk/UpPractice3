using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Ââĺäčňĺ ďĺđâîĺ ÷čńëî:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ââĺäčňĺ âňîđîĺ ÷čńëî:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Âűáĺđčňĺ îďĺđŕöčţ:");
        Console.WriteLine("1. Ńëîćĺíčĺ");
        Console.WriteLine("2. Âű÷čňŕíčĺ");
        Console.WriteLine("3. Óěíîćĺíčĺ");
        Console.WriteLine("4. Äĺëĺíčĺ");

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
            case 4:
                result = Divide(num1, num2);
                break;

            default:
                Console.WriteLine("Íĺâĺđíî âűáđŕíŕ îďĺđŕöč˙");
                break;
        }

        Console.WriteLine("Đĺçóëüňŕň: " + result);
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

    static double Divide(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Íŕ íîëü äĺëčňü íĺëüç˙!");
            return 0;
        }
    }
}

