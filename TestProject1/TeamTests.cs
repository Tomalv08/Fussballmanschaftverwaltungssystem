using Fussballverwaltungssystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballverwaltungssystem
{
    [TestFixture]
    public class TeamTests
    {
        [TestCase("Max", 22, 50000)]
        [TestCase("Alice", 25, 60000)]
        [TestCase("Bob", 20, 45000)]
        [TestCase("Chris", 28, 65000)]
        public void Team_AddMitglied_IncreasesMitgliederListeCount(string name, int age, int gehalt)
        {
            // Arrange
            Team team = new Team();
            Spieler spieler = new Spieler(name, age,gehalt);

            // Act
            team.AddMitglied(spieler);

            // Assert
            Assert.That(team.mitgliederListe.Count, Is.EqualTo(1));
        }
        [TestCase("Dilara", 28, 6500)]
        [TestCase("Igor", 12, 10)]
        [TestCase("Tomas", 18, 800000)]
        [Test]
        public void Team_ShowTeamInfo_WritesToConsole(string name, int age, int gehalt)
        {
            // Arrange
            Team team = new Team();
            Spieler spieler = new Spieler(name, age, gehalt);
            team.AddMitglied(spieler);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            team.ShowTeamInfo();

            // Assert
            StringAssert.Contains("Teaminformationen:", consoleOutput.ToString());
            StringAssert.Contains($"Spieler: {spieler.GetName()}, Alter: {spieler.GetAlter()}, Gehalt: {spieler.GetGehalt()}, Spielstunden: {spieler.spielstunden}", consoleOutput.ToString());
        }
    }
}
