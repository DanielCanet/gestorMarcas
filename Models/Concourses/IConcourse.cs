using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{
    public enum eConcourseType { shots, jumps }

    public interface IConcourse : IEvent
    {
        eEventType EventType { get; set; }
        //{
        //    get { return eEventType.concourse; }
        //    set { this.EventType = eEventType.concourse; }
        //}
        eConcourseType ConcourseType { get; set; }
    }
}
