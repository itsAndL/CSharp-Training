using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Test
{
    public class CandidatesTests
    {
        [Fact]
        public void EmailToYouIfYouQualified_YouAreQualified() 
        {
            // Arrange
            Qualifications q = new Qualifications()
            {
                BackendScale = 8.2,
                FocusOnEngineeringForMLSystems = true,
                Fluence = Qualifications.Fluency.Csharp
            };

            Candidate candidate = new Candidate() { Qualification = q };

            // Act
            var actual = candidate.EmailToYouIfYouQualified();
            
            // Assert
            Assert.True(actual.Count == 2);
            Assert.Contains("To ", actual[0]);
            Assert.Contains("Hello ", actual[1]);
        }

        [Fact]
        public void EmailToYouIfYouQualified_YouAreNotQualified_Throws()
        {
            // Arrange
            Qualifications q = new Qualifications()
            {
                BackendScale = 7.2,
                FocusOnEngineeringForMLSystems = true,
                Fluence = Qualifications.Fluency.Csharp
            };

            Candidate candidate = new Candidate() { Qualification = q };

            // Assert && Act
            Assert.Throws<Exception>(() => candidate.EmailToYouIfYouQualified());
        }
    }
}
