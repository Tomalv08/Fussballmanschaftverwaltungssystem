using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballverwaltungssystem
{
    public class Trainer : Mitglied, ITrainer
    {
        private int trainingseinheiten;
        public int Trainingseinheiten
        {
            get { return trainingseinheiten; }
            set { trainingseinheiten = value; }
        }

        public Trainer(string name, int alter, int gehalt) : base(name, alter, gehalt)
        {
            trainingseinheiten = 0;
        }

        public void Coachen()
        {
            Console.WriteLine($"{name} coacht.");
            trainingseinheiten++;
        }

        public void PlanenTraining()
        {
            Console.WriteLine($"{name} plant das nächste Training.");
        }

        public override void InfoAnzeigen()
        {
            Console.WriteLine($"Trainer: {name}, Alter: {alter}, Gehalt: {gehalt}, Trainingseinheiten: {trainingseinheiten}");
        }
    }

}
