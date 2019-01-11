using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Culture
    {
        private string _name;// Название культуры растения
        private double _normalMoisture;// Нормальная влажноть поддержания растения

        public double GetNormalMoisture()
        {
            return _normalMoisture;
        }
        public void SetNormalMoisture(double normalMoisture)
        {
            _normalMoisture = normalMoisture;
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

    }
}
