using System;

namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot(100, "Kalle", 25);
            Robot robot2 = new Robot(50, "Eva", 20);
            //Robot r = new Robot();
            //robot.SetName("Nisse");
            //string name = robot.GetName();
            
              robot.Age = -11;
            //try
            //{
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Wrong age " + e.Message);
            //}

            int[] arr = { 2, 3, 4, 5, 6, 7, 8 };

            int x = arr[100];

            robot = null;

            var age = robot?.Age;

            //int age = robot2.Age;

            //robot.Age2 = 25;
            //var age2  = robot2.Age2;
            
        }
    }
}
