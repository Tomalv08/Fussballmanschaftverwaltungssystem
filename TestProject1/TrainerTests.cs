using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballverwaltungssystem
{
    [TestFixture]   
    public class TrainerTests
    {
        [Test]
        [TestCase("Alex", 35, 80000)]
        [TestCase("Sarah", 28, 70000)]
        [TestCase("John", 40, 90000)]
        public void Trainer_Coachen_IncreasesTrainingseinheiten(string trainerName, int trainerAge, int trainerSalary)
        {
            // Arrange
            Trainer trainer = new Trainer(trainerName, trainerAge, trainerSalary);

            // Act
            trainer.Coachen();

            // Assert
            Assert.That(trainer.Trainingseinheiten, Is.EqualTo(1));
        }

        [Test]
        [TestCase("Alex", 35, 80000)]
        [TestCase("Sarah", 28, 70000)]
        [TestCase("John", 40, 90000)]
        public void Trainer_PlanenTraining_WritesToConsole(string trainerName, int trainerAge, int trainerSalary)
        {
            // Arrange
            Trainer trainer = new Trainer(trainerName, trainerAge, trainerSalary);
            var consoleOutput = new System.IO.StringWriter();
            System.Console.SetOut(consoleOutput);

            // Act
            trainer.PlanenTraining();

            // Assert
            StringAssert.Contains($"{trainerName} plant das nächste Training.", consoleOutput.ToString());
        }
    }
}
