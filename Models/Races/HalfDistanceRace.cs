using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestorMarcas.Models
{
    public enum eHalfDistanceRaceType { m800ll, m1500ll }

    public class HalfDistanceRace : IRace
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
        public eVelocityRaceType HalfDistanceRaceType { get; set; }
    }
}