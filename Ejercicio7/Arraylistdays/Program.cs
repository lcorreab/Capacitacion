using System;
using System.Collections ;

namespace Arraylistdays {
    class Program {
        static void Main (string[] args) {
            ArrayList arr = new ArrayList ();
            arr.Add ("domingo");
            arr.Add ("Lunes");
            arr.Add ("Martes");
            arr.Add ("Miercoles");
            arr.Add ("Jueves");
            arr.Add ("Viernes");
            arr.Add ("Sabado");
            Console.WriteLine ("los elementos del ArrayList son:");
            foreach (object dia in arr) {
                Console.WriteLine (dia);
                
            }
            Console.WriteLine(" El numero de elementos del arreglo es"+ arr.Count);
            
        }
    }
}