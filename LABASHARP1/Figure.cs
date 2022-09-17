using System;
using System.Collections.Generic;
using System.Text;

namespace LABASHARP1
{
   public class Figure
    {
        public Figure(Point A, Point B, Point C)
        {
            Points = 3;
            Points_List.Add(A);
            Points_List.Add(B);
            Points_List.Add(C);
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            Points = 4;
            Points_List.Add(A);
            Points_List.Add(B);
            Points_List.Add(C);
            Points_List.Add(D);
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            Points = 5;
            Points_List.Add(A);
            Points_List.Add(B);
            Points_List.Add(C);
            Points_List.Add(D);
            Points_List.Add(E);
        } // ****** ***** ) 

        public double PerimeterCalculator() // периметр
        {
            double Perimetr = 0;
            for (int i = 0; i < Points; ++i)
            {
               
                {
                    double segment = get_length(Points_List[(i + 1)%Points], Points_List[i]);
                    Perimetr += segment;
                }
                
            }
            return Perimetr;
        }
        public double get_length(Point A, Point B) // Длинна вектора AB
        {
            return Math.Sqrt(Math.Pow(B.Api_X - A.Api_X, 2) + Math.Pow(B.Api_Y - A.Api_Y, 2));
        }


        private string Name { get
            {
                if (Points < 3 ) return "incorrect figure";      
                else if (Points == 3) return "triangle";
                else if (Points == 4) return "square";
                else if (Points == 5) return "pentagon";
                else return "incorrect figure";
            } 
        }
        private int Points = 0;
        private List<Point> Points_List = new List<Point>();
    }
}
