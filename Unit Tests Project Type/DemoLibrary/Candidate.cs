using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Candidate
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Qualifications Qualification { get; set; }

        public List<string> EmailToYouIfYouQualified()
        {
            bool youAreIn = Qualification.AreYouQualified();
            if(!youAreIn)
            {
                throw new Exception("Sorry Dude, You're not qualified");
            }

            List<string> EmailToYou = new();
            EmailToYou.Add($"To {Email}");
            EmailToYou.Add($"Hello {FullName}, Congratulation You are in for the interview");
            
            return EmailToYou;
        }
    }
}
