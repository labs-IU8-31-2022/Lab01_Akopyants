using System;
using System.Collections.Generic;
using System.Text;

namespace LABASHARP1
{
    public class Rectangle
    {
        public Rectangle(double _Size_A, double _Size_B)
        {

            Size_A = Math.Abs(_Size_A);
            Size_B = Math.Abs(_Size_B);
        }
        double AreaCalculator()
        {

            return Size_A * Size_B;
        }
        double PerimeterCalculator()
        {
            return 2*(Size_A + Size_B);
        }
        private double Size_A = 0;
        private double Size_B = 0;

        public double Area { get { return AreaCalculator(); } }
        public double Perimeter { get { return PerimeterCalculator(); } }
        
    }
}

