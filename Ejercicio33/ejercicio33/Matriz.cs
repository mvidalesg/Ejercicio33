using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio33
{
    class Matriz
    {
        public int Filas { get; }
        public int Columnas { get; }
        private int[,] Datos;

        // Constructor
        public Matriz(int filas, int columnas)
        {
            Filas = filas;
            Columnas = columnas;
            Datos = new int[filas, columnas];
        }

        // Método para llenar la matriz 
        public void Llenar(Func<int, int, int> formula)
        {
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    Datos[i, j] = formula(i, j);
                }
            }
        }

        // Método para imprimir la matriz
        public void Imprimir()
        {
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    Console.Write(Datos[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Método para multiplicar dos matrices
        public static Matriz Multiplicar(Matriz A, Matriz B)
        {
            if (A.Columnas != B.Filas)
            {
                throw new InvalidOperationException("Las matrices no son multiplicables.");
            }

            Matriz C = new Matriz(A.Filas, B.Columnas);

            for (int i = 0; i < A.Filas; i++)
            {
                for (int j = 0; j < B.Columnas; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < A.Columnas; k++)
                    {
                        suma += A.Datos[i, k] * B.Datos[k, j];
                    }
                    C.Datos[i, j] = suma;
                }
            }

            return C;
        }
    }
}