using System;
using System.Collections.Generic;

namespace listanimals {
    class Program {
        static void Main (string[] args) {
            var animals = new List<string> () { "gato", "perro" };
            // Insert strings from an array in position 1.
            animals.InsertRange (1, new string[] { "leon", "oso" });
            animals.InsertRange (2, new string[] { "caballo", "aguila" });
            animals.Sort();
            
            foreach (string value in animals) {
                Console.WriteLine ("RESULTADO: " + value.ToUpper());
            }
        }
    }
}