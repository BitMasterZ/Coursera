using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args){
        //Variables
            float P1_X, P1_Y;
            float P2_X, P2_Y;
            float deltaX, deltaY;
            float distance;
            float angle;

        //Welcome
            Console.WriteLine("Welcome User. This application is used to calculate the distance and angle between two points\n");

        //Get Input
            Console.Write("Enter the X Coordinate for Point 1: ");
            P1_X = float.Parse(Console.ReadLine());
            Console.Write("Enter the Y Coordinate for Point 1: ");
            P1_Y = float.Parse(Console.ReadLine());

            Console.Write("Enter the X Coordinate for Point 2: ");
            P2_X = float.Parse(Console.ReadLine());
            Console.Write("Enter the Y Coordinate for Point 2: ");
            P2_Y = float.Parse(Console.ReadLine());

       //Calculate
            deltaX = P2_X - P1_X;
            deltaY = P2_Y - P1_Y;
            distance = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            angle = (float)(Math.Atan2(deltaY, deltaX) * 180 / Math.PI);

            //Output
            Console.WriteLine("\nThs distance between the two points is: " + distance.ToString("F3"));
            Console.WriteLine("Ths angle between the two points is: " + angle.ToString("F3") + " degrees\n");
        }
    }
}
