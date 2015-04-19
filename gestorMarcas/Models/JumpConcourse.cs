using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gestorMarcas.Models
{
    public enum eJumpType { hightJump, poleVount, longJump, tripleJump }

    public class JumpConcourse : IConcourse
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

        public eJumpType JumpType { get; set; }

    }
}