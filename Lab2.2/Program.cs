using System;

public class Program
{
    public static void Main()
    {
        Bai1a();
        Bai1b();
    }

    public static void Bai1a()
    {
        var userInfo = new { id = "2024", name = "faker", isPlaying = false, bag = new { skins = 0, cups = 20 } };
        Console.WriteLine("id: " + userInfo.id);
        Console.WriteLine("name: " + userInfo.name);
        Console.WriteLine("isplaying: " + userInfo.isPlaying);
        Console.WriteLine("bag skins: " + userInfo.bag.skins);
        Console.WriteLine("bag cups: " + userInfo.bag.cups);
    }

    public static void Bai1b()
    {
        int y = 10;
        Action<int> AnonymousMethod = delegate (int x)
        {
            int sum = x + y;
            int sub = sum - y;
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("sub: " + sub);
        };
        AnonymousMethod(5);
    }
}