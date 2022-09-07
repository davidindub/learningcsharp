using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class Computer
    {

        protected string _name = "Unknown";

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

    }
}
