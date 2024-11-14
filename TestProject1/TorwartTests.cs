using Fussballverwaltungssystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballverwaltungssystem
{
    [TestFixture]
    public class TorwartTests
    {
        [Test]
        [TestCase("Tom", 25, 60000)]
        [TestCase("Anna", 30, 70000)]
        [TestCase("Chris", 28, 65000)]
        public void Torwart_Fangen_WritesToConsole(string torwartName, int torwartAge, int torwartSalary)
        {
            // Arrange
            Torwart torwart = new Torwart(torwartName, torwartAge, torwartSalary);
            var consoleOutput = new System.IO.StringWriter();
            System.Console.SetOut(consoleOutput);

            // Act
            torwart.Fangen();

            // Assert
            StringAssert.Contains($"{torwartName} fängt den Ball.", consoleOutput.ToString());
        }

        [Test]
        [TestCase("Tom", 25, 60000, 2000)]
        [TestCase("Anna", 30, 70000, 1500)]
        [TestCase("Chris", 28, 65000, 1800)]
        public void Torwart_ErhoehenGehaltBonus_IncreasesGehaltBonus(string torwartName, int torwartAge, int torwartSalary, int bonus)
        {
            // Arrange
            Torwart torwart = new Torwart(torwartName, torwartAge, torwartSalary);

            // Act
            torwart.ErhoehenGehaltBonus(bonus);

            // Assert
            Assert.That(torwart.gehaltBonus, Is.EqualTo(bonus));
        }
    }
}
