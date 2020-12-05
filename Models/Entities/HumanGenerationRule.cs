using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class HumanGenerationRule
    {
        public int InitialFloor { get; set; }
        public int Finitefloor { get; set; }
        public int InSeconds { get; set; }

        public HumanGenerationRule(int init, int finite, int inSec)
        {
            InitialFloor = init;
            Finitefloor = finite;
            InSeconds = inSec;
        }
    }
}
