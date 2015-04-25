using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{
    public enum eSex { M, F }

    public interface IPerson
    {
        DateTime BornDate { get; set; }
        eSex Sex { get; set; }
    }
}
