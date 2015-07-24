using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.WebPages;
using System.Xml; 
using System.Xml.Linq;
using WebGrease.Css.Ast.Selectors;

namespace gestorMarcas.Models
{

    public class AthleticEvent
    {

        //private XElement xElement { get; set; }
        private XmlDocument xml { get; set; }

        public AthleticEvent(String xmlFilePath)
        {
            string mapLoc = HttpContext.Current.Request.MapPath(xmlFilePath);

            this.xml = new XmlDocument();
            xml.Load(mapLoc); 

        }

        public decimal GetVelocityRacePercentage(Athlete athlete, VelocityRace athleticVelocityRace, decimal personalResult)
        {
            decimal result = 0;

            decimal bestTableResult = GetVelocityRaceTableResult(athlete, athleticVelocityRace.VelocityRaceType);
            result = bestTableResult * 100 / personalResult;
            result = decimal.Round(result, 2);

            return result;
        }

        public decimal GetVelocityRaceTableResult(Athlete athlete, eVelocityRaceType velocityRaceType)
        {
            decimal result = 0;

            string bornYear = athlete.GetYearsOld().ToString();
            string sex = athlete.Sex.ToString();

            XmlNodeList xnList = xml.SelectNodes("/bestMarks/category[@sex='" + sex + "' and @age='" + bornYear + "']/event[@name='" + velocityRaceType + "']");

            foreach (XmlNode xn in xnList)
            {
                result = xn.InnerText.AsDecimal();
            }

            return result;
        }

    }
}