using System;
using System.Collections.Generic;
using System.Text;

namespace LABASHARP1
{
    public class Point
    {
        public Point(double _X, double _Y )
        {
            X = _X;
            Y = _Y; 
        }

       

        private readonly double X = 0;
        private readonly double Y = 0;
        public double Api_X { get { return X; } }
        public double Api_Y { get { return Y; } }
    }
 
}

