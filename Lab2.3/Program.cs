using System;
using System.Collections.Generic;

public class UserData
{
    public int ID { get; set; }
    public string UserName { get; set; }
    public List<float> Scores { get; set; }

    public UserData(int id, string userName)
    {
        ID = id;
        UserName = userName;
        Scores = new List<float>();
    }

    public void AddScores(List<float> data)
    {
        Scores.AddRange(data);
    }
}

public class Program
{
    public static void Main()
    {
        List<float> ldata = new List<float>() { 10, 9, 8, 7.5f, 2, 1.4f };

        UserData userData = new UserData(12345, "John Doe");
        userData.AddScores(ldata);

        Console.WriteLine("User ID: " + userData.ID);
        Console.WriteLine("Username: " + userData.UserName);
        Console.Write("Scores: ");
        foreach (var score in userData.Scores)
        {
            Console.Write(score + " ");
        }
    }
}