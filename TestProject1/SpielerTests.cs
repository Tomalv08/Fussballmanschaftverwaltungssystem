using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballverwaltungssystem
{
    [TestFixture]
    public class SpielerTests
    {
        [Test]
        [TestCase("Max", 22, 30000)]
        [TestCase("Dan", 15, 45000)]
        [TestCase("Tomas", 18, 670000)]
        public void Spieler_Trainieren_IncreasesSpielstunden(string playerName, int playerAge, int playerSalary)
        {
            // Arrange
            Spieler spieler = new Spieler(playerName, playerAge, playerSalary);

            // Act
            spieler.Trainieren();

            // Assert
            Assert.That(spieler.spielstunden, Is.EqualTo(1));
        }

        [Test]
        [TestCase("Max", 22, 50000)]
        [TestCase("Dan", 15, 60000)]
        [TestCase("Tomas", 18, 60000)]
        public void Spieler_Spielen_WritesToConsole(string playerName, int playerAge, int playerSalary)
        {
            // Arrange
            Spieler spieler = new Spieler(playerName, playerAge, playerSalary);
            var consoleOutput = new System.IO.StringWriter();
            System.Console.SetOut(consoleOutput);

            // Act
            spieler.Spielen();

            // Assert
            StringAssert.Contains($"{playerName} spielt ein Fußballspiel.", consoleOutput.ToString());
        }
    }
}
