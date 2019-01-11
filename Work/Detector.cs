using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Detector
    {
        private double _moisture;// Влажность почвы

        public double GetMoisture()
        {
            return _moisture;
        }
        public void SetMoisture(double moisture)
        {
            _moisture = moisture;
        }
    }
}
