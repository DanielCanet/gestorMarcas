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

        private XElement xElement { get; set; }

        public AthleticEvent(String xmlFilePath)
        {
            this.xElement = XElement.Load(xmlFilePath);
        }

        public decimal GetVelocityRacePercentage(Person.eSex sex, int bornYear, VelocityRace athleticVelocityRace, decimal personalResult)
        {
            decimal result = 0;

            decimal bestTableResult = GetVelocityRaceTableResult(sex, bornYear, athleticVelocityRace.VelocityRaceType);
            result = bestTableResult * 100 / personalResult;
            result = decimal.Round(result, 2);

            return result;
        }

        public decimal GetVelocityRaceTableResult(Person.eSex sex, int bornYear, eVelocityRaceType velocityRaceType)
        {
            decimal result = 0;

            string x = bornYear.ToString();
            var mark = from nm in this.xElement.Elements("category")
                        where (string)nm.Attribute("age") == bornYear.ToString() && (string)nm.Element("event").Attribute("name") == velocityRaceType.ToString()                           
                        select nm.Element("event");
            foreach (XElement bestMark in mark)
            {
                result = bestMark.Element("mark").Value.AsDecimal();
            }

            return result;
        }
    }
}