using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{

    public enum eShot { disc, put, hammer, javalin }

    public interface IShot : IConcourse
    {
        eEventType EventType { get; set; }
        eConcourseType ConcourseType { get; set; }
        eShot ShotType { get; set; }
    }
}
