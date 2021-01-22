using System;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace Lab09LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText("../../../data.json");
            var root = JsonConvert.DeserializeObject<Root>(json);

            int counter = 1;
            // Question 1
            Console.WriteLine("Output all of the neighborhoods in this data list (Final Total: 147 neighborhoods)");
            var query = from Feature in root.features
                        select Feature.properties.neighborhood;

            foreach(string hood in query)
                Console.WriteLine($"{ counter++}. {hood} ");

            Pause();
//----------------------------------------------
            // Question 2
            Console.WriteLine("Filter out all the neighborhoods that do not have any names (Final Total: 143)");
            counter = 1;
            query = from Feature in root.features
                        where Feature.properties.neighborhood != ""
                        select Feature.properties.neighborhood;

            foreach (string hood in query)
                Console.WriteLine($"{ counter++}. {hood} ");

            Pause();
//-------------------------------------------------
            // Question 3
            Console.WriteLine("Remove the duplicates (Final Total: 39 neighborhoods)");
            counter = 1;
            IEnumerable<string> distincthoods = query.Distinct();
            foreach (string hood in distincthoods)
                Console.WriteLine($"{ counter++}. {hood} ");

            Pause();
//-------------------------------------------------
            // Question 4
            Console.WriteLine("Rewrite the queries from above and consolidate all into one single query");
            counter = 1;

            distincthoods = root.features
                .Where(hood => hood.properties.neighborhood != "")
                .Select(hood => hood.properties.neighborhood).Distinct();

            foreach (string hood in distincthoods)
                Console.WriteLine($"{ counter++}. {hood} ");

            Pause();
//-------------------------------------------------
            //Question 5
            Console.WriteLine("Rewrite at least one of these questions only using the opposing method" +
                "Redoing question 2");
            counter = 1;

            distincthoods = root.features
               .Where(hood => hood.properties.neighborhood != "")
               .Select(hood => hood.properties.neighborhood);

            foreach (string hood in distincthoods)
                Console.WriteLine($"{ counter++}. {hood} ");

        }

        public static void Pause()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        } 
        
        public class Geometry
        {
            public string type { get; set; }
            public List<double> coordinates { get; set; }
        }

        public class Properties
        {
            public string zip { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string address { get; set; }
            public string borough { get; set; }
            public string neighborhood { get; set; }
            public string county { get; set; }

            //public Properties(string[] strArr) { }
        }

        public class Feature
        {
            public string type { get; set; }
            public Geometry geometry { get; set; }
            public Properties properties { get; set; }

        
        }

        public class Root
        {
            public string type { get; set; }
            public List<Feature> features { get; set; }
        }
    }
}
