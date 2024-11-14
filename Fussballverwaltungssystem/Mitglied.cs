using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballverwaltungssystem
{
    public abstract class Mitglied : IMitglied
    {
        protected string name;
        protected int alter;
        protected int gehalt;

        public Mitglied(string name, int alter, int gehalt)
        {
            this.name = name;
            this.alter = alter;
            this.gehalt = gehalt;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAlter()
        {
            return alter;
        }

        public int GetGehalt()
        {
            return gehalt;
        }
        public abstract void InfoAnzeigen();
    }
}
