using System;
using System.Runtime.InteropServices;

namespace LABASHARP1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*task1
            var types = new[]
            {

            typeof(sbyte),
            typeof(byte),
            typeof(short),
            typeof(ushort),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(float),
            typeof(double),
            typeof(decimal),
            typeof(string),
            };


            // Отступы каждых столбцов (10 первый, 20 второй, по 30 два последних) + 5 символов "|"
            Console.WriteLine(new string('-', 10 + 20 + 30 + 30 + 5));
            Console.WriteLine("|{0,10}|{1,20}|{2,30}|{3,30}|", "Type", "Byte(s) of memory", "Min", "Max");
            Console.WriteLine(new string('-', 10 + 20 + 30 + 30 + 5));

            foreach (var type in types)
            {
                var size = Marshal.SizeOf(type);
                var min = type.GetField("MinValue").GetValue(null); // Берем нужное поле из типа
                var max = type.GetField("MaxValue").GetValue(null); // и забираем его значение

                Console.WriteLine("|{0,10}|{1,20}|{2,30}|{3,30}|", type.Name.ToLower(), size, min, max);
            }
            */

            /*task2
            double value1 = 0;
            double value2 = 0;
            Console.WriteLine("enter the rectangle's parametres");
            value1 = Convert.ToDouble(Console.ReadLine());
            value2 = Convert.ToDouble(Console.ReadLine());
            Rectangle obj = new Rectangle(value1, value2);
            Console.WriteLine($"the rectangle's area = {obj.Area} \n the rectangle perimetr = {obj.Perimeter} ");*/

            /*tast3*/
            Point obj1 = new Point(5, 6);
            Point obj2 = new Point(8, 10); 
            Point obj3 = new Point(3, 9);
            

            Figure obj = new Figure(obj1, obj2, obj3);
            Console.WriteLine($" figure's perimeter = ");
            Console.WriteLine(obj.PerimeterCalculator());
            

        }
            
    }
}
