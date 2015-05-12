using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestorMarcas.Models
{
    public abstract class Person
    {
        public enum eSex { M, F }

        public DateTime BornDate { get; set; }
        public eSex Sex { get; set; }
    }
}