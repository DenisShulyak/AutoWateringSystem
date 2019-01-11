using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class AutoIrrigationSystem
    {
        private Field[] _fields; // поля для орошения

        public Field[] GetField()
        {
            return _fields;
        }
    }
}
