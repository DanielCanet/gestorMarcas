using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{

    public enum eShot { disc, put, hammer, javalin }

    public class Shot : IConcourse
    {
        public eEventType EventType
        {
            get { return eEventType.concourse; }
            set { }
        }

        public eConcourseType ConcourseType
        {
            get { return eConcourseType.jumps; }
            set { }
        }
        eShot ShotType { get; set; }
    }
}
