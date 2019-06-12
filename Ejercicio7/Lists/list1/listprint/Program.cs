using System;
using System.Collections.Generic;

namespace listprint {
    class Program {
        public static void Main (string[] args) {
            List<int> list = new List<int> ();
            list.Add (4);
            list.Add (7);
            list.Add (9);
            list.Add (11);

            // Loop through List with foreach.
            foreach (int num in list) {
                Console.WriteLine (num);
            }
        }
    }
}