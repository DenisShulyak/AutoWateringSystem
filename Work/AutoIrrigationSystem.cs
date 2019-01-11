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
        private IrrigationType _irrigationType; // тип орошения

        public Field[] GetField()
        {
            return _fields;
        }

        public IrrigationType GetIrrigationType()
        {
            return _irrigationType;
        }
        public void SetIrrigationType(IrrigationType irrigationType)
        {
            _irrigationType = irrigationType;
        }
    }
}
