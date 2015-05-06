using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestorMarcas.Models
{
    public class MastersCategory : ICategory
    {

        private int GetYearsOld(Athlete athlete)
        {
            int diffYear = DateTime.Today.Year - athlete.BornDate.Year;

            if (DateTime.Today.Month < athlete.BornDate.Month)
            {
                return diffYear - 1;
            }
            else if (DateTime.Today.Month == athlete.BornDate.Month)
            {
                if (DateTime.Today.Day < athlete.BornDate.Day) { return diffYear - 1; }
                else if (DateTime.Today.Day == athlete.BornDate.Day) { return diffYear; }
                else { return diffYear; }
            }
            else
            {
                return diffYear;
            }
        }

        public string GetCategory(Athlete athlete)
        {
            int result = this.GetYearsOld(athlete) / 5 * 5;
            return athlete.Sex + result.ToString();
        }

        public string GetYearCategory(Athlete athlete)
        {
            return athlete.Sex + this.GetYearsOld(athlete).ToString();
        }
    }
}