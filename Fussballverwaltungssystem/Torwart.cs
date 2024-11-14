using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballverwaltungssystem
{
    public class Torwart : Spieler, ITrainierbar
    {
        public int gehaltBonus{ get; private set; }

        public Torwart(string name, int alter, int gehalt) : base(name, alter, gehalt)
        {
            // Zusätzliche Initialisierungen für einen Torwart können hier gemacht werden
            gehaltBonus = 0;
        }

        public void Fangen()
        {
            Console.WriteLine($"{GetName()} fängt den Ball.");
        }

        public void ErhoehenGehaltBonus(int bonus)
        {
            gehaltBonus += bonus;
            Console.WriteLine($"{GetName()}: Gehaltbonus wurde um {bonus} erhöht. Gesamte Gehaltbonus: {gehaltBonus}");
        }

        // Überschreiben der Trainieren-Methode
        public override void Trainieren()
        {
            Console.WriteLine($"{GetName()} trainiert speziell als Torwart.");
        }
    }
}         
