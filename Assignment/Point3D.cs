using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Point3D : ICloneable, IComparable<Point3D>
    {

        int x { get; set; }
        int y { get; set; }
        int z { get; set; }
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return Equals(p1, p2);
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !Equals(p1, p2);
        }
        public object Clone()
        {
            return new Point3D(x, y, z);
        }

        public int CompareTo(Point3D? other)
        {
            return x != other?.x ? x.CompareTo(other?.x) : y.CompareTo(other.y);
        }
    }
}
