using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using JUST;
using System.IO;

namespace JUST.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = File.ReadAllText("/Users/Jake/source/repos/Cost_Estimator/Cost_Estimator_JSON/data/stair_configuration.json");

            string transformer = File.ReadAllText("/Users/Jake/source/repos/Cost_Estimator/Cost_Estimator_JSON/data/transformer.json"); ;

            string transformedString = JsonTransformer.Transform(transformer, input);

            Console.WriteLine(transformedString);
        }
    }
}