//Jayrell Garcia
//SP25-CPSC-23000-001 - .NET Programming
//This Program l calculate the values of polynomial functions of up to degree 3 over a domain.

namespace Homework__2_Polynomial_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {   //print main header and description
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("                    POLYNOMIAL CALCULATOR V1.0");
            Console.WriteLine("----------------------------------------------------------------------\n\n");

            Console.WriteLine("This tool helps you calculate the values of cubic, quadratic, linear,\nand constant polynomials over a specified domain. " +
                "You will enter the\ncoefficients of the polynomial along with the miniumum and maximum of\nthe domain, and I will do the rest.");

            
            int polynomialCount = 1; //declare and initialize polynomial count
            bool continueCalculating = true; //declare and initialize continueCalculating to true to keep loop running , false when user select to stop. 

            //start of main loop
            while (continueCalculating)
            {
                Console.WriteLine($"\nEnter the details for polynomial #{polynomialCount}");

                // Get the degree of the polynomial
                int degree = -1;
                while (degree < 0 || degree > 3)
                {
                    //ask user for polynomial degree
                    Console.Write("Enter the degree of the polynomial : ");
                    try
                    {   //attempt to parse into a double and check if its within range of 0-3, if not raise an error
                        degree = int.Parse(Console.ReadLine());
                        if (degree < 0 || degree > 3)
                        {
                            //throw expcetion  if not  within range of 0-3, make comment about how you havent lerned this but know how it works cause JAVA and W3 schools
                            throw new Exception();
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Invalid input. Please enter an integer between 0 and 3.");
                        degree = -1; // Reset to invalid value to retry
                    }



                }

                //Print the f(x) for the degree choosen
                string polynomial = "";

                if (degree == 3)
                {
                    polynomial += "ax^3 + ";
                }
                if (degree >= 2)
                {
                    polynomial += "bx^2 + ";
                }
                if (degree >= 1)
                {
                    polynomial += "cx + ";
                }
                if (degree >= 0)
                {
                    polynomial += "d";
                }
                //print f(x) function 
                Console.WriteLine("Specify the coefficients for f(x) = " + polynomial + ":");

                // Get coefficients based on the degree 
                double[] coefficients = new double[4]; // a, b, c, d

                if (degree >= 0)
                {   
                    bool validNumber = false;
                    Console.Write("Enter d: ");
                    //while loop keeps executing until a valid repsonse is recorded
                    while (!validNumber)
                    {
                        try
                        {   // attempt to parse input
                            coefficients[3] = double.Parse(Console.ReadLine());
                            validNumber = true;
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                            Console.Write("Enter d: ");
                        }
                    }
                }
                if (degree >= 1)
                {
                    bool validNumber = false;
                    Console.Write("Enter c: ");
                    while (!validNumber)
                    {
                        try
                        {
                            coefficients[2] = double.Parse(Console.ReadLine());
                            validNumber = true;
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                            Console.Write("Enter c: ");
                        }
                    }
                }
                if (degree >= 2)
                {
                    bool validNumber = false;
                    Console.Write("Enter b: ");
                    while (!validNumber)
                    {
                        try
                        {
                            coefficients[1] = double.Parse(Console.ReadLine());
                            validNumber = true;
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                            Console.Write("Enter b: ");
                        }
                    }
                }
                if (degree == 3)
                {
                    bool validNumber = false;
                    Console.Write("Enter a: ");
                    while (!validNumber)
                    {
                        try
                        {
                            coefficients[0] = double.Parse(Console.ReadLine());
                            validNumber = true;
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("Invalid input. Please enter a numeric value.");
                            Console.Write("Enter a: ");
                        }
                    }
                }

                // Get min and max x values
                double minX = 0;
                double maxX = 0;
                Console.Write("Enter min x: ");
                // while loop keeps executing until a valid repsonse is recorded
                while (true)
                {
                    try
                    {
                        minX = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                        Console.Write("Enter min x: ");
                    }
                }



                Console.Write("Enter max x: ");
                while (true)
                {
                    try
                    {
                        maxX = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                        Console.Write("Enter max x: ");
                    }
                }

                // Swap minX and maxX if minX > maxX
                if (minX > maxX)
                {
                    double temp = minX;
                    minX = maxX;
                    maxX = temp;
                }

                // print polynomial
                Console.WriteLine("\nHere is the polynomial over the domain {0} through {1}:", minX, maxX);
                Console.WriteLine("x\t\ty");

                // Calculate and display the polynomial values
                for (double x = minX; x <= maxX; x++)
                {
                    double y = coefficients[0] * Math.Pow(x, 3) +
                               coefficients[1] * Math.Pow(x, 2) +
                               coefficients[2] * x +
                               coefficients[3];
                    Console.WriteLine($"{x}\t\t{y:F2}");
                }

                // ask if the user wants to compute another polynomial
                Console.Write("\nDo you want to compute another polynomial (y or n)? ");
                string response = Console.ReadLine().Trim().ToLower();
                if (response != "y")
                {
                    continueCalculating = false;
                    Console.WriteLine("\nThat was so crazy fun I bet you got dizzy.");
                }
                else
                {
                    polynomialCount++;
                }
            }
        }
    }
}
