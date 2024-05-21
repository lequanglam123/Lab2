using System;

public class Program
{
    public static void Bai1b()
    {
        Console.WriteLine("Bai 1b:");

        void GetDetail(dynamic value)
        {
            Console.WriteLine("Value: " + value);
        }

        GetDetail(10);
        GetDetail("Game");

        Console.WriteLine();
    }
}