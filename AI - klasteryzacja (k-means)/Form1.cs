using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI___klasteryzacja__k_means_
{
    public partial class Form1 : Form
    {
        private int _numOfDataObjs;
        private int _numOfCetroids;
        private int w, h;
        private List<DataObject> _objects;
        kMeans kMeans;

        private Random _rnd;
        public Form1()
        {
            InitializeComponent();
            _rnd = new Random();
            w = pictureBox1.Width;
            h = pictureBox1.Height;

            _numOfDataObjs = 1000;
            _numOfCetroids = 20;
            _objects = new List<DataObject>();

            _genDataObjs();

            this.kMeans = new kMeans(_numOfCetroids, _objects);
        }

        private void _genDataObjs ()
        {
            for (int i = 0; i < _numOfDataObjs; i++)
            {
                DataObject obj = new DataObject(new ObjectPrototype(w * _rnd.NextDouble(), h * _rnd.NextDouble(), _rnd.Next(3, 8)));
                _objects.Add(obj);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            foreach (DataObject obj in _objects)
            {
                obj.Draw(g);
            }

            kMeans.Draw(g);
        }
    }
}
