using Fussballverwaltungssystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballverwaltungssystem
{
    [TestFixture]
    public class MitgliedTests
    {
        [Test]
        [TestCase("Max", 22, 50000)]
        [TestCase("Dan", 15, 60000)]
        [TestCase("Tomas", 18, 100000)]
        public void Mitglied_InfoAnzeigen_WritesCorrectInfoToConsole(string name, int alter, int gehalt)
        {
            // Arrange
            Mitglied mitglied = new Spieler(name, alter, gehalt);
            var consoleOutput = new System.IO.StringWriter();
            System.Console.SetOut(consoleOutput);

            // Act
            mitglied.InfoAnzeigen();

            // Assert
            StringAssert.Contains(name, consoleOutput.ToString());
            StringAssert.Contains(alter.ToString(), consoleOutput.ToString());
            StringAssert.Contains(gehalt.ToString(), consoleOutput.ToString());
        }
    }
}
