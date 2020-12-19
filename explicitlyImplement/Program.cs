using System;

namespace explicitlyImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDimensions dimensions = new Box(30.0f, 20.0f);
            IDimensions dimensions = new Box(30.0f, 20.0f);

            var result = dimensions.GetLength();
            Console.WriteLine($"{result}");
        }
    }

    }
