using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI___klasteryzacja__k_means_
{
    class ObjectPrototype
    {
        public ObjectPrototype (double x, double y, double r)
        {
            X = x;
            Y = y;
            R = r;
        }
        public double X {  get; set; }
        public double Y {  get; set; }
        public double R {  get; set; }

        public static double Distance(ObjectPrototype f1, ObjectPrototype f2)
        {
            return (f1.X - f2.X) * (f1.X - f2.X) + (f1.Y - f2.Y) * (f1.Y - f2.Y);
        }
    }
}
