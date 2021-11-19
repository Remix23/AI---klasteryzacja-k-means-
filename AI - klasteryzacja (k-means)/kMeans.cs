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
        private List<DataObject> _objects;

        private List<Centroid> _centroids;

        private List<ObjectPrototype> _objPrototypes;

        private int _cetroidSize;

        public kMeans (int num_of_cetroids, List<DataObject> objects)
        {
            _numOfCentroids = num_of_cetroids;
            _objects = objects;
            _cetroidSize = 15;
            _centroids = new List<Centroid>();
            _objPrototypes = _objects.Select(x => x.Proto).ToList();
            _genCetroids();
        }


        private void _genCetroids ()
        {
            for (int i = 0; i < _numOfCentroids; i++)
            {
                Color color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                ObjectPrototype obj_proto = _objPrototypes[rnd.Next(_objPrototypes.Count)];
                _objPrototypes.Remove(obj_proto);

                Centroid centroid = new Centroid(obj_proto, color, _cetroidSize);
                _centroids.Add(centroid);
            }
        }

        public void PairPointsAndCetroids ()
        {
            double distance, dis;
            Centroid nearest_centroid;
            foreach (DataObject obj in _objects)
            {
                distance = -1;
                if (_centroids.Count <= 0) continue;
                nearest_centroid = _centroids[0];
                for (int i = 1; i < _centroids.Count; i++)
                {
                    dis = ObjectPrototype.Distance(obj.Proto, _centroids[i].Center);

                    if (distance == -1 | dis < distance) 
                    { 
                        nearest_centroid = _centroids[i];
                        distance = dis;
                    }
                }
                nearest_centroid.AddDataObj(obj);
            }
        }

        public void UpdateCetroids ()
        {
            foreach (Centroid centroid in _centroids)
            {
                centroid.UpdateCenter();
            }
        }

        public void Iterate (int n )
        {
            for (int i = 0; i < n; i++)
            {
                PairPointsAndCetroids();
                UpdateCetroids();
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
