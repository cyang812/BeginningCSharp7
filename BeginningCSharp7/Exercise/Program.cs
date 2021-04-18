using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, world");
            Orientation myDirection;
            for (int myByte = 1; myByte <= 300; myByte++)
            {
                try
                {
                    myDirection = ((Orientation)myByte); //checked
                    if ((myDirection < Orientation.North) ||
                        (myDirection > Orientation.West)) 
                    {
                        throw new ArgumentOutOfRangeException("myByte", myByte,
                            "Value must be between 1 and 4");
                    }
                }
                catch (ArgumentOutOfRangeException e)               
                {
                    Console.WriteLine(e.Message);
                    myDirection = Orientation.West;                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Different");
                    myDirection = Orientation.North;
                }
                Console.WriteLine($"myDirection = {myDirection}");
            }
        }
    }
    enum Orientation : byte
    {
        North = 1,
        South = 2,
        East = 3,
        West = 4
    }
}
