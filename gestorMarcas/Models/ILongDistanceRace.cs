using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{

    public enum eLongDistanceRaceType { m3000ll, m3000obs, m5000ll, m10000ll, HalfMarathon, Marathon, Cros }

    public interface ILongDistanceRace : IRace
    {
        eEventType EventType { get; set; }
        eRaceType RaceType { get; set; }
        eLongDistanceRaceType LongDistanceRaceType { get; set; }
    }
}
