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

        private List<DataObject> _connectedObjects;

        public Centroid(ObjectPrototype center, Color color, int centroid_size)
        {
            Center = center;
            Color = color;
            this.Center.R = centroid_size;
            _connectedObjects = new List<DataObject>();
        }

        public void UpdateCenter ()
        {
            if (_connectedObjects.Count == 0) return;
            double average_x = 0;
            double average_y = 0;
            foreach (DataObject obj in _connectedObjects)
            {
                average_x += obj.Proto.X;
                average_y += obj.Proto.Y;
            }
            average_x /= _connectedObjects.Count;
            average_y /= _connectedObjects.Count;

            Center.X = average_x;
            Center.Y = average_y;

        }

        public void AddDataObj (DataObject obj)
        {
            _connectedObjects.Add(obj);
        }
        public void Draw (Graphics g)
        {
            Brush brush= new SolidBrush (this.Color);
            g.FillRectangle(brush, Convert.ToInt32(Center.X - Center.R / 2), Convert.ToInt32(Center.Y - Center.R), Convert.ToInt32(Center.R), Convert.ToInt32(Center.R));
            foreach (DataObject obj in this._connectedObjects)
            {
                obj.Draw (g, Color);
            }
            _connectedObjects.Clear();
        }
    }
}
