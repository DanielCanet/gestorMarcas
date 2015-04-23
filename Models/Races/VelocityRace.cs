using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestorMarcas.Models
{

    public enum eVelocityRaceType { m60ll, m100ll, m200ll, m400ll }

    public class VelocityRace : IRace
    {       
        public eEventType EventType {
            get { return eEventType.race; }
            set { }
        }
        public eRaceType RaceType {
            get { return eRaceType.velocity; }
            set { }
        }
        public eVelocityRaceType VelocityRaceType { get; set; }

    }
}