using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{

    public enum eHurdlesRaceType { m110v, m100v, m400v }

    public interface IHurdlesRace : IRace
    {
        eEventType EventType { get; set; }
        eRaceType RaceType { get; set; }
        eHurdlesRaceType HurdlesRaceType { get; set; }
    }
}
