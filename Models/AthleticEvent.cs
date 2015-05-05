using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using System.Xml; 
using System.Xml.Linq;
using WebGrease.Css.Ast.Selectors;

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
        private XElement xElement { get; set; }

        public AthleticEvent(String xmlFilePath)
        {
            this.xElement = XElement.Load(xmlFilePath);
        }

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

                var mark = from nm in this.xElement.Elements("category")
                           where (string)nm.Attribute("age") == "35" && (string)nm.Element("event").Attribute("name") == "m60ll"                           
                           select nm.Element("event");
                //&& (string)nm.Attribute("sex") == "M"
                foreach (XElement bestMark in mark)
                {
                    result = bestMark.Element("mark").Value.AsDecimal();
                }

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