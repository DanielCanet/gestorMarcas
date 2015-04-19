using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestorMarcas.Models
{

    public class AthleticEvent
    {

        public decimal GetPercentage(eSex sex, int bornYear, IEvent athleticEvent, decimal personalResult)
        {
            decimal result = 0;
            if (athleticEvent.EventType == eEventType.race)
            {
                decimal bestTableResult = GetTableResult(sex, bornYear, athleticEvent);
                result = bestTableResult * 100 / personalResult;
                result = decimal.Round(result, 2);
            }else if(athleticEvent.EventType == eEventType.concourse)
            {
                decimal bestTableResult = GetTableResult(sex, bornYear, athleticEvent);
                result = personalResult * 100 / bestTableResult;
                result = decimal.Round(result, 2);
            }

            return result;
        }

        public decimal GetTableResult(eSex sex, int bornYear, IEvent athleticEvent)
        {
            if (athleticEvent.EventType == eEventType.race)
            { 
                return 6.46m;
            }
            else { return 8.24m; }
            
        }
    }
}