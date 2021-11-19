using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AI___klasteryzacja__k_means_
{
    class DataObject
    {

        public ObjectPrototype Proto;

        public DataObject(ObjectPrototype proto)
        {
            Proto = proto;
        }

        public void Draw (Graphics g)
        {
            g.DrawEllipse(Pens.Black, (int)Proto.X, (int)Proto.Y, (int)Proto.R, (int)Proto.R);
        }

        public void Draw(Graphics g, Color color)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, (int)Proto.X, (int)Proto.Y, (int)Proto.R - 2, (int)Proto.R - 2);
        }

    }
}
