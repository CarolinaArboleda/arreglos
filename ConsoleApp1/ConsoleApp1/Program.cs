using System;

namespace arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de arreglos de diferentes tipos y diferentes dimensiones

            //VECTORES (arreglos en una dimensión).

            //vector tipo string
            string[] v_frutas; //vector clase string vacío
            v_frutas = new string[5]; //se declara el vector con 5 posiciones
            v_frutas[0] = "manzana"; v_frutas[1] = "banano"; v_frutas[2] = "pera"; v_frutas[3] = "fresa";v_frutas[4] = "mango";
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(v_frutas[i]);
            }

            Console.WriteLine(" ");

            //vector tipo int
            int[] v_deuda = new int[8]; //se declara el vector con 8 posiciones
            for(int i = 0; i < 8; i++)
            {
                Console.Write(v_deuda[i] + "|"); 
                //al imprimirlo en consola, se puede observar que el vector se inicializa con 0 por defecto
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //vector tipo float
            float[] v_notas = new float[] {3.5f,4.2f,3.1f,5.0f,2.8f };
            //en este caso, el tamaño del vector es igual a la cantidad de elementos asignados
            for (int i = 0; i < v_notas.Length; i++)
            {
                Console.WriteLine(v_notas[i]);
            }
        }
    }
}
