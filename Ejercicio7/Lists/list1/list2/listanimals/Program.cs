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
             List<string> animalscopy = new List<string>(animals); 
            animalscopy.Add("perro labrador");
            animalscopy.Add("gato siames");

            foreach (string value in animals) {
                Console.WriteLine ("Animal coleccion 1 es: " + value.ToUpper());
               
            }

            foreach (string newvalue in animalscopy) {
                Console.WriteLine ("Animal coleecion 2 es: " + newvalue.ToUpper());
               
            }

             Console.WriteLine("el numero de objetos  de la lista 1 es " +  animals.Count);
              Console.WriteLine("el numero de objetos  de la lista 2 es " +  animalscopy.Count);
        }

    }
}