﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{

    public enum eRaceType { velocity, halfDistance, longDistance, hurdles }

    public interface IRace : IEvent
    {
        eEventType EventType { get; set; }
        //{
        //    get { return eEventType.race; }
        //    set { this.EventType = eEventType.race; }
        //}
        eRaceType RaceType { get; set; }
    }
}