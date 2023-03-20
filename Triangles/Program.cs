

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //  Adding the initial input for Coordinate numbers, keeping it simple no error handle enable

        Console.WriteLine("Enter the coordinate x of dot A:");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinate y of dot A:");
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinate x of dot B:");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinate y of dot B:");
        double y2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinate x of dot C:");
        double x3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinate y of dot C:");
        double y3 = double.Parse(Console.ReadLine());


        // Calculate the lengths of the sides

        double sideAB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double sideBC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double sideAC = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));



        /*   Determine the type of triangle
          - Equilateral all sides must be equal
          - Isosceles one of the sides must be equal
          - Right sum of square of 2 sides should equal 1 side square */

        bool Equilateral = sideAB == sideBC && sideBC == sideAC;
        bool Isosceles = sideAB == sideBC || sideBC == sideAC || sideAC == sideAB;
        bool Right = (int)Math.Round(Math.Pow(sideAB, 2) + Math.Pow(sideBC, 2)) == (int)Math.Round(Math.Pow(sideAC, 2)) ||
                       (int)Math.Round(Math.Pow(sideBC, 2) + Math.Pow(sideAC, 2)) == (int)Math.Round(Math.Pow(sideAB, 2)) ||
                       (int)Math.Round(Math.Pow(sideAB, 2) + Math.Pow(sideAC, 2)) == (int)Math.Round(Math.Pow(sideBC, 2));

        // Perimeter
        double perimeter = sideAB + sideBC + sideAC;
        


        // Print the lenght of the sides
        Console.Write("\n");
        Console.WriteLine($"Lenght of AB is: '{sideAB}'");
        Console.WriteLine($"Lenght of BC is: '{sideBC}'");
        Console.WriteLine($"Lenght of AC: '{sideAC}'");
        Console.Write("\n");

        // Print the type of triangles
        if (Equilateral == true)
        {
            Console.WriteLine($"Triangle IS 'Equilateral'");
        }
        else
        {
            Console.WriteLine($"Triangle IS NOT 'Equilateral'");
        }

        if (Isosceles == true)
        {
            Console.WriteLine($"Triangle IS 'Isosceles'");
        }
        else
        {
            Console.WriteLine($"Triangle IS NOT 'Isosceles'");
        }
        if (Right == true)
        {
            Console.WriteLine($"Triangle IS 'Right'");
        }
        else
        {
            Console.WriteLine($"Triangle IS NOT 'Right'");
        }

        // Print the perimeter & Parity
        Console.Write("\n");
        Console.WriteLine($"Perimeter: '{perimeter}'");
        // Print the perimeter
        Console.Write("\n");
        Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
        for (int i = 0; i <= perimeter; i++)
        {
            if (i % 2 == 0)
            {   
                Console.Write($"{i}");
                Console.Write("\n");
            }
        }

    }
}





