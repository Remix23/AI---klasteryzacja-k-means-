using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AI___klasteryzacja__k_means_
{
    class Centroid
    {
        public ObjectPrototype Center;

        public Color Color;

        public List<DataObject> ConnectedObjects = new List<DataObject>();

        public Centroid(ObjectPrototype center, Color color)
        {
            Center = center;
            Color = color;
        }

        public void Draw (Graphics g)
        {
            Brush brush= new SolidBrush (this.Color);
            g.FillRectangle(brush, (int)Center.X, (int)Center.Y, 5, 5);
            foreach (DataObject obj in this.ConnectedObjects)
            {
                obj.Draw (g, Color);
            }
        }

    }
}
