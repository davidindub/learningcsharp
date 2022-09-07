using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class Desktop : Computer
    {
        public enum CaseType
        {
            Tower,
            MiniTower
        }

        public CaseType caseType { get; private set; }

        public override string name { get
            {
                return base.name + " " + caseType;
            }
        }

        public Desktop(string name, CaseType caseType) : base(name)
        {
            this.caseType = caseType;
            
        }
    }
}
