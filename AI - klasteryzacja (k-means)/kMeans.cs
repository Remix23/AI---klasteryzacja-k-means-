using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AI___klasteryzacja__k_means_
{
    class kMeans
    {
        Random rnd = new Random();
        private int _numOfCentroids;
        private List<DataObject> _objects = new List<DataObject>();
        
        private List<Centroid> _centroids = new List<Centroid>();

        public kMeans (int num_of_cetroids, List<DataObject> objects)
        {
            this._numOfCentroids = num_of_cetroids;
            this._objects = objects;
            this._genCetroids();
        }

        private void _genCetroids ()
        {
            for (int i =0; i < _numOfCentroids; i++)
            {
                Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                ObjectPrototype obj_proto = _objects[rnd.Next(_objects.Count)].Proto;

                Centroid centroid = new Centroid(obj_proto, color);
                _centroids.Add(centroid);

            }
        }

        public void Draw (Graphics g)
        {
            foreach (Centroid cetroid in _centroids)
            {
                cetroid.Draw(g);
            }
        }


    }
}
