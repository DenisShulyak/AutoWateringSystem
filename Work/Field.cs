using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{

    class Field
    {
        private double _area; // плошадь поля
        private Detector[] _detectors; // детекторы влажности
        private Culture _culture; // культура растений

        public double GetArea() 
        {
            return _area;
        }
        public void SetArea(double area)
        {
            _area = area;
        }

        public Detector[] GetDetectors()
        {
            return _detectors;
        }

        public Culture GetCulture()
        {
            return _culture;
        }
        public void SetCulture(string name, double normalMoisture)
        {
            _culture.SetName(name);
            _culture.SetNormalMoisture(normalMoisture);
        }
    }

}
