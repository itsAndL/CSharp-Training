using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace DemoLibrary.Test
{
    public class QualificationsTests
    {
        [Fact]
        public void AreYouQualified_RequirementData()
        {
            // Arrange
            Qualifications q = new()
            {
                BackendScale = 8.2,
                FocusOnEngineeringForMLSystems = true,
                Fluence = Qualifications.Fluency.Csharp
            };

            // Expected
            bool expected = true;

            // Act
            bool actual = q.AreYouQualified();

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void AreYouQualified_InrequirementData()
        {
            // Arrange
            Qualifications q = new Qualifications()
            {
                BackendScale = 7.2,
                FocusOnEngineeringForMLSystems = true,
                Fluence = Qualifications.Fluency.Java
            };

            // Expected
            bool expected = false;

            // Act
            bool actual = q.AreYouQualified();

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}
