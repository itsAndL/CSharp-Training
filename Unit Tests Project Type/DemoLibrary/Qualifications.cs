using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Qualifications
    {
        public double BackendScale { get; set; }
        public bool FocusOnEngineeringForMLSystems { get; set;}
        public Fluency Fluence { get; set; }

        public enum Fluency { Csharp, CPlusPLus, Java}

        public bool AreYouQualified()
        {
            return (BackendScale > 7.5 && FocusOnEngineeringForMLSystems == true) ? true: false;
        }
    }
}
