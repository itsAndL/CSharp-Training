using System;
using System.Collections.Generic;
using System.Reflection;
					
namespace Training
{
	public class Program
	{
		public static void Main()
		{
			List<Car> cars = new List<Car>()
			{
				new Car() { Factory = "Nissan", Model = "2011" },
				new Car() { Factory = "Ford", Model =  "2022" } 
			};
			
			//List<Friend> friends = new List<Friend>()
			//{
			//	new Friend() { Name = "Kendra", Age = 26 },
			//	new Friend() { Name = "Tim", Age = 35 } 
			//};
			
			DerivedClass AnInstance = new DerivedClass() { Data = cars[0]};
			AnInstance.AMethod();
			AnInstance.ThanksToYou<string>("Dude your Time is Out");
		}
	}
}
	
namespace Training
{
	public class JustAClass<Tclass> where Tclass : class, new()
	{
		public Tclass Data {get; set;}
		public string Message {get;} = "You got this";
		
		public void AMethod()
		{
			Tclass entry = new Tclass();
			PropertyInfo[] cols = entry.GetType().GetProperties();
			
			foreach(var col in cols)
			{
				Console.Write($"{col.Name} = {col.GetValue(entry)}, ");
			}
			
			Console.WriteLine();
			Console.WriteLine($"===> {Message.ToUpper()}");
		}
		
	}
	public class DerivedClass : JustAClass<Car>
	{
		
		public void ThanksToYou<Tstring>(Tstring aFeedback)
		{
			if("System.String" != aFeedback.GetType().ToString())
			{
			 	throw new Exception("Tstring must be a sring");
			}
			Console.WriteLine($"Thanks for your FeedBack: <{aFeedback}>");
		}
	}
}
	
namespace Training
{
		public class Friend
	{
		public string Name {get; set;}
		public int Age {get; set;}
	}
	
	public class Car 
	{
		public string Factory {get; set;}
		public string Model {get; set;}
	}
}
