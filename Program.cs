using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Training
{
  public class Program
  {
    public static void Main()
    {
      DemonstrateTextFileStorage();
    }
    private static void DemonstrateTextFileStorage()
    {
      List<Person> people = new List<Person>();
      List<LogEntry> logs = new List<LogEntry>();

      string peopleFile = @"C:\Users\lenovo\source\people.csv";
      string LogFile = @"C:\Users\lenovo\source\logs.csv";

      PopulateLists(people, logs);

      OriginalTextFileProcessor.SavePeople(people, peopleFile);
      
      var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

      foreach(var p in newPeople)
      {
        Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
      }
    }

    private static void PopulateLists(List<Person> people, List<LogEntry> logs)
    {
      people.Add(new Person() {FirstName = "Tim", LastName = "Corey"});
      people.Add(new Person() {FirstName = "Sue", LastName = "Storm", IsAlive = false });
      people.Add(new Person() {FirstName = "Greg", LastName = "Olsen"});

      logs.Add(new LogEntry() {Message = "I blow up", ErrorCode = 3103});
      logs.Add(new LogEntry() {Message = "I'm too awesomw", ErrorCode = 2202});
      logs.Add(new LogEntry() {Message = "I was tired", ErrorCode = 9997});
    }
  }
}

namespace Training
{
  public static class OriginalTextFileProcessor
  {
    public static void SavePeople(List<Person> people, string filePath)
    {
      List<string> lines = new List<string>();

      lines.Add("FirstName,IsAlive,LastName");

      foreach(var p in people)
      {
        lines.Add($"{p.FirstName},{p.IsAlive},{p.LastName}");
      }

      File.AppendAllLines(filePath, lines);
    }

    public static List<Person> LoadPeople(string filePath)
    {
      List<Person> output = new List<Person>();
      Person p;
      var lines = File.ReadAllLines(filePath).ToList();
      lines.RemoveAt(0);

      foreach(var line in lines)
      {
        var vals = line.Split(',');

        p = new Person() 
        {
          FirstName = vals[0],
          LastName = vals[1],
          IsAlive = bool.Parse(vals[2])
        };
        output.Add(p);
      }
      return output;
    }
  }
}

namespace Training
{
  public class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsAlive { get; set; } = true;
  }

  public class LogEntry
  {
    public int ErrorCode { get; set; }
    public string Message { get; set; }
    public DateTime TimeOfEvent { get; } = DateTime.Now;
  }
}
