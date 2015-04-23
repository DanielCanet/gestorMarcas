using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestorMarcas.Models
{

    public class AthleticEvent
    {

        //public decimal GetPercentage(eSex sex, int bornYear, IEvent athleticEvent, decimal personalResult)
        //{
        //    decimal result = 0;
        //    if (athleticEvent.EventType == eEventType.race)
        //    {
        //        decimal bestTableResult = GetTableResult(sex, bornYear, athleticEvent);
        //        result = bestTableResult * 100 / personalResult;
        //        result = decimal.Round(result, 2);
        //    }else if(athleticEvent.EventType == eEventType.concourse)
        //    {
        //        decimal bestTableResult = GetTableResult(sex, bornYear, athleticEvent);
        //        result = personalResult * 100 / bestTableResult;
        //        result = decimal.Round(result, 2);
        //    }

        //    return result;
        //}

        public decimal GetVelocityRacePercentage(eSex sex, int bornYear, VelocityRace athleticVelocityRace, decimal personalResult)
        {
            decimal result = 0;

            decimal bestTableResult = GetVelocityRaceTableResult(sex, bornYear, athleticVelocityRace.VelocityRaceType);
            result = bestTableResult * 100 / personalResult;
            result = decimal.Round(result, 2);

            return result;
        }

        public decimal GetVelocityRaceTableResult(eSex sex, int bornYear, eVelocityRaceType velocityRaceType)
        {
            decimal result = 0;

            if (velocityRaceType == eVelocityRaceType.m60ll)
            {
                result = 6.61m;
            }else if (velocityRaceType == eVelocityRaceType.m100ll)
            {
                result = 6.61m;
            }else if (velocityRaceType == eVelocityRaceType.m200ll)
            {
                result = 6.61m;
            }else if (velocityRaceType == eVelocityRaceType.m400ll)
            {
                result = 6.61m;
            }

            return result;
        }
    }
}