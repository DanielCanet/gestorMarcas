using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{

    public enum eHurdlesRaceType { m110v, m100v, m400v }

    public class IHurdlesRace : IRace
    {
        public eEventType EventType
        {
            get { return eEventType.race; }
            set { }
        }
        public eRaceType RaceType
        {
            get { return eRaceType.halfDistance; }
            set { }
        }
        eHurdlesRaceType HurdlesRaceType { get; set; }
    }
}
