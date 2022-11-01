# cuboid
test project


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuboid aCuboid = new Cuboid();
            aCuboid.height = 20;
            aCuboid.width = 40;
            aCuboid.length = 60;
            aCuboid.ShowAllProperties();
            Cuboid cuboid2 = new Cuboid(30, 40, 55);
            cuboid2.ShowAllProperties();
            cuboid2.width = 50;
            cuboid2.ShowAllProperties();
            Console.WriteLine("volume of the cuboid2 ={0}", cuboid2.Volume());
            Console.WriteLine("Surface Area of the cuboid2 ={0}", cuboid2.SurfaceArea());
            Console.ReadKey();
        }
    }

    interface Shape3DCalculator
    {
        double Volume();
        double SurfaceArea();
    }

    class Cuboid : Shape3DCalculator
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
