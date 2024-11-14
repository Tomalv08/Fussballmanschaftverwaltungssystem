using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballverwaltungssystem
{
    public interface ISpieler
    {
        string GetName();
        int GetAlter();
        int GetGehalt();
        void Trainieren();
    }
}
