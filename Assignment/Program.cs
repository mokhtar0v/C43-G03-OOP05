namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Project01
            int p1x = Convert.ToInt32(Console.ReadLine());
            int p1y = Convert.ToInt32(Console.ReadLine());
            int p1z = Convert.ToInt32(Console.ReadLine());
            Point3D p1 = new Point3D(p1z, p1x, p1y);
            int p2x = Convert.ToInt32(Console.ReadLine());
            int p2y = Convert.ToInt32(Console.ReadLine());
            int p2z = Convert.ToInt32(Console.ReadLine());
            Point3D p2 = new Point3D(p2x, p2y, p2z);
            if (p1 == p2) Console.WriteLine("They're Equal");
            else Console.WriteLine("They're not Equal");
            Point3D p3 = (Point3D)p1.Clone();

            Point3D[] points = new Point3D[4];
            for (int i = 0; i < points.Length; i++)
            {
                int x, y, z;
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = Convert.ToInt32(Console.ReadLine());
                points[i] = new Point3D(x, y, z);
            }
            else Console.WriteLine("They're not equal");
            Array.Sort(points);
            Console.WriteLine("After Sorting");
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i]);
            }
            #endregion

            #region Project02
            int sum = Math.Add(1, 2);
            int difference = Math.Subtract(1, 2);
            int Multiply = Math.Multiply(1, 2);
            int Divide = Math.Divide(1, 2);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Multiply: {Multiply}");
            Console.WriteLine($"Divide: {Divide}");
            #endregion
        }
    }
}
