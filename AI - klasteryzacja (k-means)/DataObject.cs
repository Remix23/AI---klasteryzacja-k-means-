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
            g.DrawEllipse(Pens.Black, Convert.ToInt32(Proto.X - Proto.R / 2), Convert.ToInt32(Proto.Y - Proto.R / 2), (int)Proto.R, (int)Proto.R);
        }

        public void Draw(Graphics g, Color color)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, Convert.ToInt32(Proto.X - Proto.R / 2), Convert.ToInt32(Proto.Y - Proto.R / 2), (int)Proto.R, (int)Proto.R);
        }
    }
}
