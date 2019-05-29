using System;

namespace Arrays {
    class Program {
        static void Main (string[] args) {

            Array arr = new Array ();
            Console.WriteLine ("Numero de Elementos: {0}", arr.NumerosDeElementos.ToString ());
            Console.WriteLine ("Positivos_menores_iguales_a_10: {0}", arr.Contador10_positivos ());
            Console.WriteLine ("Negativos: {0}", arr.Contador_negativos ());

        }
    }
}