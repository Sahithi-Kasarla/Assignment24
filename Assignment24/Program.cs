using DynamicLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Source source = new Source
            {
                CommonProperty1 = 42,
                CommonProperty2 = "Hello, world!"
            };

            DestinationClass destination = new DestinationClass();

            // Step 3: Call the MapProperties method to map properties
            PropertyMapping.MapProperties(source, destination);

            // Step 3: Display values of properties in the destination class
            Console.WriteLine($"CommonProperty1: {destination.CommonProperty1}");
            Console.WriteLine($"CommonProperty2: {destination.CommonProperty2}");
            Console.WriteLine($"AdditionalProperty: {destination.AdditionalProperty}");
            Console.ReadKey();
        }
    }
}
