using System;
using System.Linq.Expressions;

namespace ExpressionTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating parameter
            var xParameter = Expression.Parameter(typeof(double), "x");
            var yParameter = Expression.Parameter(typeof(double), "y");

            //Creating the multiplication and addition expressions
            var xSquared = Expression.Multiply(xParameter, xParameter);
            var ySquared = Expression.Multiply(yParameter, yParameter);
            var sum = Expression.Add(xSquared, ySquared);

            // Creating a method call expressioin to call Math.Sqrt
            var sqrtMethod = typeof(Math).GetMethod("Sqrt", new[] { typeof(double) });
            var distance = Expression.Call(sqrtMethod, sum);

            // Creating a Lambda expression
            var distanceLambda = Expression.Lambda<Func<double,double,double>>(
                distance,
                xParameter,
                yParameter);

            Console.WriteLine($"The square root of x*x + y*y is {distanceLambda.Compile()(10, 5)}");


        }
    }
}
