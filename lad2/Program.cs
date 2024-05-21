using System;

public class Program
{
    public static void Main(string[] args)
    {
        Bai1a();
        Bai1b();
        Bai1c();
    }

    public static void Bai1a()
    {
        Console.WriteLine("Bai 1a:");
        var x = 10;
        Console.WriteLine("X: " + x);
        Console.WriteLine();
    }

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

    public static void Bai1c()
    {
        Console.WriteLine("Bai 1c:");
        UserData userData = new UserData(0, "first Player", "0");
        userData.ShowData("level", userData.level);
        userData.ShowData("id", userData.id);
        userData.ShowData("Username", userData.userName);
        Console.WriteLine();
    }
}

public class UserData
{
    public int id;
    public string userName;
    public string level;

    public UserData(int id, string userName, string level)
    {
        this.id = id;
        this.userName = userName;
        this.level = level;
    }

    public void ShowData()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Username: " + userName);
        Console.WriteLine("level: " + level);
    }

    public void ShowData(string name, dynamic attribute)
    {
        Console.WriteLine(name + ": " + attribute);
    }
}