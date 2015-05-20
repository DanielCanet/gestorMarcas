using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestorMarcas.Models
{
    public class Category
    {
        private readonly Athlete athlete;

        public Category(Athlete athlete)
        {
            this.athlete = athlete;
        }

        private int GetYearsOld()
        {
            int diffYear = DateTime.Today.Year - this.athlete.BornDate.Year;

            if (DateTime.Today.Month < this.athlete.BornDate.Month)
            {
                return diffYear - 1;
            }
            else if (DateTime.Today.Month == this.athlete.BornDate.Month)
            {
                if (DateTime.Today.Day < this.athlete.BornDate.Day) { return diffYear - 1; }
                else if (DateTime.Today.Day == this.athlete.BornDate.Day) { return diffYear; }
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
            return this.athlete.Sex + result.ToString();
        }

        public string GetYearCategory()
        {
            return this.athlete.Sex + this.GetYearsOld().ToString();
        }
    }
}