using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

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
      string logFile = @"C:\Users\lenovo\source\logs.csv";

      PopulateLists(people, logs);

      /* New way of doing things - generics */

      GenericTextFileProcessor.SaveToTextFile<Person>(people, peopleFile);
      GenericTextFileProcessor.SaveToTextFile<LogEntry>(logs, logFile);

      List<Person> newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFile);

      foreach(Person p in newPeople)
      {
        Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
      }

      List<LogEntry> newLogs = GenericTextFileProcessor.LoadFromTextFile<LogEntry>(logFile);

      foreach(var log in newLogs)
      {
        Console.WriteLine($"{log.ErrorCode}: {log.Message} at {log.TimeOfEvent}");
      }

      /* Old way of doing things - non-generics */

      // OriginalTextFileProcessor.SavePeople(people, peopleFile);
      
      // var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

      // foreach(var p in newPeople)
      // {
      //   Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
      // }

      // OriginalTextFileProcessor.SaveLogs(logs, logFile);

      // var newLogs = OriginalTextFileProcessor.LoadLogs(logFile);

      // foreach(var log in newLogs)
      // {
      //   Console.WriteLine($"{log.ErrorCode}: {log.Message} at {log.TimeOfEvent}");
      // }
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
  public static class GenericTextFileProcessor
  {
    // public static List<T> LoadFromTextFile<T, U>(string filePath) where T : class , new() where U: Person
    public static List<T> LoadFromTextFile<T>(string filePath) where T : class , new()
    {
      List<string> lines = File.ReadAllLines(filePath).ToList();
      List<T> output = new List<T>();
      T entry = new T();
      PropertyInfo[] cols = entry.GetType().GetProperties();

      if(lines.Count < 2)
      {
        throw new IndexOutOfRangeException("The file was either empty or missing.");
      }

      string[] headers = lines[0].Split(',');
      lines.RemoveAt(0);

      foreach(var line in lines)
      {
        string[] vals = line.Split(',');
        entry = new T();

        foreach(PropertyInfo col in cols)
        {
          for( int i = 0; i < headers.Length; i++ )
          {
            if(col.Name == headers[i])
            {
              col.SetValue(entry, Convert.ChangeType(vals[i], col.PropertyType));
              break;
            }
          }
        }

        output.Add(entry);
      } 
      
      return output;
    }

    public static void SaveToTextFile<T>(List<T> data, string filePath) where T : class, new()
    {
      List<string> lines = new List<string>();

      if(data == null || data.Count == 0)
      {
        throw new ArgumentNullException("data", "You must populate the data parameter with at least one value.");
      }

      // T entry = new T();
      // PropertyInfo[] cols = entry.GetType().GetProperties();

      PropertyInfo[] cols = data[0].GetType().GetProperties();

      string line = "";
      foreach(PropertyInfo col in cols)
      {
        line += $"{col.Name},";
      }
      lines.Add(line.Substring(0,line.Length - 1));

      foreach(T row in data)
      {

        line = "";
        foreach(PropertyInfo col in cols)
        {
          line += $"{col.GetValue(row, null)},";
        }

        lines.Add(line.Substring(0,line.Length - 1));
      }

      File.AppendAllLines(filePath, lines);
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

    public static void SaveLogs(List<LogEntry> logs, string filePath)
    {
      List<string> lines = new List<string>();

      lines.Add("ErrorCode,Message,TimeOfEvent");

      foreach(var log in logs)
      {
        lines.Add($"{log.ErrorCode},{log.Message},{log.TimeOfEvent.ToShortTimeString()}");
      }

      File.AppendAllLines(filePath, lines);
    }

    public static List<Person> LoadPeople(string filePath)
    {
      List<Person> output = new List<Person>();
      // Person p;
      var lines = File.ReadAllLines(filePath).ToList();
      lines.RemoveAt(0);

      foreach(var line in lines)
      {
        var vals = line.Split(',');

        Person p = new Person() 
        {
          FirstName = vals[0],
          LastName = vals[1],
          IsAlive = bool.Parse(vals[2])
        };
        output.Add(p);
      }
      return output;
    }

    public static List<LogEntry> LoadLogs(string filePath)
    {
      List<LogEntry> output = new List<LogEntry>();
      //LogEntry log;
      var lines = File.ReadAllLines(filePath).ToList();
      lines.RemoveAt(0);

      foreach(var line in lines)
      {
        var vals = line.Split(',');

        LogEntry log = new LogEntry() 
        {
          ErrorCode = int.Parse(vals[0]),
          Message = vals[1],
          TimeOfEvent = DateTime.Parse(vals[2])
        };
        output.Add(log);
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
    public DateTime TimeOfEvent { get; set; } = DateTime.Now;
  }
}
