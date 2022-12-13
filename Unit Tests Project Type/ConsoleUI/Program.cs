using System;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
            Qualifications q = new Qualifications()
            {
                BackendScale = 8.2,
                FocusOnEngineeringForMLSystems = true,
                Fluence = Qualifications.Fluency.Csharp
            };

            Candidate candidate = new Candidate()
            {
                FullName = "JS",
                Age = 64,
                Email = "js@gmail.com",
                Phone = "2221114444",
                Qualification = q
            };

            bool areYou = candidate.Qualification.AreYouQualified();
            List<string> message = candidate.EmailToYouIfYouQualified();

            Console.WriteLine($"Are You Qualified : {areYou}");

            Console.WriteLine("Message :");
            foreach (var line in message)
            {
                Console.WriteLine(line);
            }
        }
    }
}
