//Jayrell Garcia
//SP25-CPSC-23000-001 - .NET Programming
//This program calculates the area of cube and sphere using input from the user and prints out to the terminal

namespace Shape_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("           Shape Calculator V1.0");
            Console.WriteLine("********************************************\n");

            //cube volume
            Console.WriteLine("First, let's deal with a cube.");
            Console.Write("What is the width? ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the length? ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the height? ");
            double height = Convert.ToDouble(Console.ReadLine());

            double cubeVolume = width * length * height;
            Console.WriteLine($"The cube's volume is {cubeVolume:F3}\n");

            //sphere volume
            Console.WriteLine("Now let's deal with a sphere.");
            Console.Write("What is the radius? ");
            double radius = Convert.ToDouble(Console.ReadLine());

            //print sphere volume
            double sphereVolume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"The sphere's volume is {sphereVolume:F3}\n");

            // print total volume
            double totalVolume = cubeVolume + sphereVolume;
            Console.WriteLine($"The total volume of the cube and sphere is {totalVolume:F3}\n");

            Console.WriteLine("Thank you for using this program.");
        }
    }
}
