using System;

namespace ArraysPrint {
    class Program {
        public static void Main (string[] args) {
            int[] arr = new int[10];
            int i;
            Console.Write ("\n\n lee e imprime los valores del arreglo:\n");
            Console.Write ("-----------------------------------------\n");
            Console.Write ("ingrese 10 elementos en el arreglo :\n");
            for (i = 0; i < 10; i++) {
                Console.Write ("elemento en la posicion - {0} : ", i);
                arr[i] = Convert.ToInt32 (Console.ReadLine ());
            }
            Console.Write ("\n los Elementos en el arreglo son: ");
            for (i = 0; i < 10; i++) {
                Console.Write ("{0}  ", arr[i]);
            }
            Console.Write ("\n");
        }
    }
}