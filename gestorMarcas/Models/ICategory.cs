using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{
    public interface ICategory
    {
        string GetCategory(IPerson person);
        string GetYearCategory(IPerson person);
    }
}
