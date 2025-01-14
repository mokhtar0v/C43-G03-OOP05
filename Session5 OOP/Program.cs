using Session5_OOP.Abstraction;

namespace Session5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            //Square
            Console.WriteLine("Square:-");
            Square squ = new Square(20);
            decimal SquareArea = squ.CalcArea();
            decimal SquarePeri = squ.Parameter;
            Console.WriteLine($"Area of Square = {SquareArea}");
            Console.WriteLine($"Perimeter of Square = {SquarePeri}");
            Console.WriteLine();


            //Circle
            Console.WriteLine("Circle:-");
            Circle circle = new Circle(10);
            decimal CircleArea = circle.CalcArea();
            decimal CirclePeri = circle.Parameter;
            Console.WriteLine($"Area of Square = {CircleArea}");
            Console.WriteLine($"Perimeter of Square = {CirclePeri}");
            Console.WriteLine();


            //Rectangle
            Console.WriteLine("Rectangle:-");
            Rectangle rect = new Rectangle() { Dim01 = 10, Dim02 = 20 };
            decimal RectArea = rect.CalcArea();
            decimal RectPeri = rect.Parameter;
            Console.WriteLine($"Area of Rectangle = {RectArea}");
            Console.WriteLine($"Perimeter of Rectangle = {RectPeri}");
            Console.WriteLine();
            #endregion
        }
    }
}
