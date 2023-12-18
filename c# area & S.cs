using System;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Shape Calculator!");

            while (true)
            {
                Console.WriteLine("Choose a shape to calculate its area and perimeter:");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Square");
                Console.WriteLine("4. treingle");
                Console.WriteLine("5. Trapezius");
                Console.WriteLine("6. oval");
                Console.WriteLine("7. Polygon");
                Console.WriteLine("8. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CalculateCircle();
                        break;
                    case 2:
                        CalculateRectangle();
                        break;
                    case 3:
                        CalculateSquare();
                        break;
                    case 4:
                        calculatetreingle();
                        break;
                    case 5:
                        calculateTrapezius();
                        break;
                    case 6:
                        calculateoval();
                        break;
                    case 7:
                        calculatePolygon();
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        static void CalculateCircle()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine($"The area of the circle is: {area}");
            Console.WriteLine($"The perimeter of the circle is: {perimeter}");
        }

        static void CalculateRectangle()
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine($"The area of the rectangle is: {area}");
            Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
        }

        static void CalculateSquare()
        {
             Console.Write("Enter the side length of the square: ");
             double sideLength = Convert.ToDouble(Console.ReadLine());

             double area = sideLength * sideLength;
             double perimeter = 4 * sideLength;

             Console.WriteLine($"The area of the square is: {area}");
             Console.WriteLine($"The perimeter of the square is: {perimeter}");
         }
    }
}