using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorMarcas.Models
{
    public enum eEventType { concourse, race }

    public interface IEvent
    {
        eEventType EventType { get; set; }
    }
}
