using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Banana>(); 

        for (int i = 0; i < numberOfRecords; i++)
        {
            var banana = new Banana();

            Console.WriteLine("Enter the calories: ");
            banana.Calories = int.Parse(Console.ReadLine());

            recordList.Add(banana);
        }

        foreach (var record in recordList)
        {
            Console.WriteLine(record.ToString());
        }
    }
}

class Fruit
{
    public int Calories { get; set; }
}

class Banana : Fruit
{
    public override string ToString()
    {
        return $"Calories: {Calories}";
    }
}