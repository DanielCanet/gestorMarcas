using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{

    public enum eLongDistanceRaceType { m3000ll, m3000obs, m5000ll, m10000ll, HalfMarathon, Marathon, Cros }

    public class LongDistanceRace : IRace
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
        eLongDistanceRaceType LongDistanceRaceType { get; set; }
    }
}
