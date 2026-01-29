using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class BMIberekenen

    {
        private double _lengteInMeter;
        private double _gewichtInKg;

        public BMIberekenen(double lengteInMeter, double gewichtInKg)
        {
            _lengteInMeter = lengteInMeter;
            _gewichtInKg = gewichtInKg;
        }
        public double Gewicht
        {
            get { return _gewichtInKg; }
            set { _gewichtInKg = value; }
        }
        public double Lengte
        {
            get { return _lengteInMeter; }
            set { _lengteInMeter= value; }
        }
        public double BerekenBmi()
        {
            return _gewichtInKg/(_lengteInMeter*_lengteInMeter);
        }
    }
}
