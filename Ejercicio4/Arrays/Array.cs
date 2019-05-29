using System;
using System.Collections;

namespace Arrays {
    public class Array {

        private int[] numeros = { 1, 7, 2, -5, 4, 2, 3, 8, 11, 4, 6, 4, 4, 10, 10, 4, 7 };

        public Array () {

            NumerosDeElementos = numeros.Length;
        }

        public int NumerosDeElementos { get; set; }

        public int Contador10_positivos () {
            int counter = 0;
            for (int i = 0; i < NumerosDeElementos; i++) {
                if (numeros[i] >= 0 && numeros[i] <= 10)
                    counter++;
            }

            return counter;
        }

        public int Contador_negativos () {
            int contador = 0;
            for (int i = 0; i < NumerosDeElementos; i++) {
                if (numeros[i] < 0)
                    contador++;
            }

            return contador;
        }

    }
}