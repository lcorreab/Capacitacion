using System;

namespace ReverseArray {
    class Program {
       public  static void Main (string[] args) {
            int i, n;
            int[] a = new int[100];
            Console.Write ("lee n numero de valores en un arreglo y muestra en orden inverso");
               
            Console.Write ("------------------------------------------------------------ ------------\n");
            Console.Write ("Ingrese los elementos a almacenar en el arreglo :");
            n = Convert.ToInt32 (Console.ReadLine ());
            Console.Write ("ingreso de elementos {0} numero de elementos en el arreglo :\n", n);
            for (i = 0; i < n; i++) {
                Console.Write ("elemento - {0} : ", i);
                a[i] = Convert.ToInt32 (Console.ReadLine ());
            }
            Console.Write ("\n los valores en el arreglo son : \n");
            for (i = 0; i < n; i++)

            {
                Console.Write ("{0}  ", a[i]);
            }
            Console.Write ("\n\n los valores en orden inverso son :\n");
            for (i = n - 1; i >= 0; i--) {
                Console.Write ("{0} ", a[i]);
            }
            Console.Write ("\n\n");
        }
    }
}