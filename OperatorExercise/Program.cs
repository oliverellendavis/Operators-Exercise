using System;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var sum = a + b;
            var difference = a - b;
            var product = a * b;
            var quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"Addition: {a} + {b} = {sum}");
            Console.WriteLine($"Subtraction: {a} - {b} = {difference}");
            Console.WriteLine($"Multiplication: {a} * {b} = {product}");
            Console.WriteLine($"Division: {a} / {b} = {quotient} remainder {remainder}");
            Console.WriteLine($"Modulus: {a} % {b} = {remainder}");

            Console.Write("What is the radius of your circle? ");
            var radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);

            Console.WriteLine($"The area of the circle with radius {radius} is {area}");
        }

        static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }        
    }
}
