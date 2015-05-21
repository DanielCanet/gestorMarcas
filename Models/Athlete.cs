using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestorMarcas.Models
{

    public class Athlete : Person
    {
        public string LicenceId { get; set; }

        public int GetYearsOld()
        {
            int diffYear = DateTime.Today.Year - BornDate.Year;

            if (DateTime.Today.Month < BornDate.Month)
            {
                return diffYear - 1;
            }
            else if (DateTime.Today.Month == BornDate.Month)
            {
                if (DateTime.Today.Day < BornDate.Day) { return diffYear - 1; }
                else if (DateTime.Today.Day == BornDate.Day) { return diffYear; }
                else { return diffYear; }
            }
            else
            {
                return diffYear;
            }
        }

        public string GetCategory()
        {
            int result = this.GetYearsOld() / 5 * 5;
            return Sex + result.ToString();
        }

        public string GetYearCategory()
        {
            return Sex + this.GetYearsOld().ToString();
        }
    }
}