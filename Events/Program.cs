using System;

namespace Training
{
  class Program
  {
    static void Main()
    {
      Person person = new Person("Kendra", 27);
      person.PersonInfo += MInformation;
      person.AMethod();
    }

    public static void MInformation(object sender, Person p, IDKArgs e)
    {
      Console.WriteLine($"Here's the message : {e.Message}");
      e.EMethod();
      Console.WriteLine($"Name = {p.Name}, Age = {p.Age}");
    }
  }
}

namespace Training
{
  public delegate void PersonHandler(object sender, Person p, IDKArgs e); // DELEGATE definition

  public class Person
  {
    public event PersonHandler PersonInfo; // EVENT definition

      // when The EVENT PersonInfo is RAISED, invokes the PersonHandler delegate.
      // DELEGATES implement EVENT HANDLING
    
    public string Name { get; }
    public int Age { get; }
    public Person( string name, int age)
    {
      Name = name;
      Age = age;
    }

    public void AMethod()
    {
      IDKArgs e = new IDKArgs("Almost, just come back and check all the stuff that dosn't make sence, reread the article.");
      OnPersonInfo(this, e); // the EVENT : we just call the method AMethod()
    }

    private void OnPersonInfo(Person p, IDKArgs e)
    {
      if( PersonInfo != null ) PersonInfo(this, p, e); // RAISE the EVENT
    }
  }
}

namespace Training
{
  public class IDKArgs : EventArgs
  {
    public string Message { get; set; }
    public IDKArgs(string message) => Message = message;
  }
}

namespace Training
{
  public static class Extension
  {
    public static void EMethod(this IDKArgs a)
    {
      Console.WriteLine($"{a.Message.Substring(0,10)} ++ hello again :)");
    }
  }
}
