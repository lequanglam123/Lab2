using System;

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

public class Program
{
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
