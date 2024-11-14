using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballverwaltungssystem
{
    public class Team : ITeam
    {
        public List<IMitglied> mitgliederListe { get; private set; }

        public Team()
        {
            mitgliederListe = new List<IMitglied>();
        }

        public void AddMitglied(IMitglied mitglied)
        {
            mitgliederListe.Add(mitglied);
        }

        public void ShowTeamInfo()
        {
            Console.WriteLine("Teaminformationen:");
            foreach (var mitglied in mitgliederListe)
            {
                mitglied.InfoAnzeigen();
            }
        }
    }
}
