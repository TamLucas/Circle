using System;

namespace Tester_cs
{

    class Circle
    {

        //Properties
        private double Radius;
        private double Area;
        private double Circumference;
        private const double PI = Math.PI; //using built in PI 

        //Constructor
        public Circle(double Radius)
        {
            this.Radius = Radius;
            this.Area = 0.0;
            this.Circumference = 0.0;
        }
        //Methods
        public void GetArea()
        {
                  
            this.Area = PI * Math.Pow(Area, 2);
        }

        public void GetCircumference()
        {
            this.Circumference = 2 * PI * Radius;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Circle Information:");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Area}");
            Console.WriteLine($"Circumference: {Circumference}");
           
        }
       

        class Program
        {
            static void Main(string[] args)
            {
                Circle C1 = new Circle(5.0);
                C1.GetArea(); //Call to calculate Area
                C1.GetCircumference(); //Call to calculate Circumference
                C1.PrintInfo(); 
            }
        }
    }

}
