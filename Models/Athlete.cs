using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestorMarcas.Models
{

    public class Athlete : Person
    {
        public DateTime BornDate { get; set; }
        public eSex Sex { get; set; }

        public string LicenceId { get; set; }
    }
}