using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    internal class Cuboid
    {
        private double _height;
        private double _width;
        private double _length;

        public double height
        {
            set { _height = value; }
            get { return _height; }
        }
        public double width
        {
            set { _width = value; }
            get { return _width; }
        }
        public double length
        {
            set { _length = value; }
            get { return _length; }
        }

        public Cuboid()
        {
            height = 0;
            width = 0;
            length = 0;
        }
        public Cuboid(double _height, double _width, double _length)
        {
            height = _height;
            width = _width;
            length = _length;
        }
        public void ShowAllProperties()
        {
            Console.WriteLine("height={0},width={1},length={2}", height, width, length);
        }

        public double Volume()
        {
            return _height * _width * _length;
        }

        public double SurfaceArea()
        {
            return 2 * _height * _width * _length * _height + _width + _length;
        }
    }
}
