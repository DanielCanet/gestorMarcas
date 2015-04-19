using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{

    public enum eHalfDistanceRaceType { m800ll, m1500ll }

    public interface IHalfDistanceRace : IRace
    {
        eEventType EventType { get; set; }
        eRaceType RaceType { get; set; }
        eHalfDistanceRaceType HalfDistanceRaceType { get; set; }
    }
}
