/* Ejercicio (Arreglos Paralelos): Se desea desarrollar un programa que registre los 
nombres de n estudiantes y sus notas en n evaluaciones (3) de la asignatura 
Metodología y Programación Estructurada. El programa debe:
1. Pedir al usuario la cantidad de estudiantes. Trabajar con no menos de tres 
estudiantes.
2. Crear un arreglo unidimensional para almacenar los nombres de los estudiantes.
3. Crear una matriz bidimensional para almacenar las notas de los estudiantes en 
3 exámenes.
4. Calcular el promedio de notas de cada estudiante.
5. Imprimir el nombre de cada estudiante, sus 3 notas y el promedio, indicando si 
aprobó o no el curso. Se considera aprobado, si el promedio es igual o mayor a 
70. Imprimir cuál fue el estudiante con mayor nota final.
Nota: Para cualquier iteración, utilice sólo la instrucción for*/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n;
        for (n = 1; n <= 2; n++)
        {
            Console.Write("Ingrese la cantidad de estudiantes (mínimo 3): ");
            n = int.Parse(Console.ReadLine());
        }
        string[] nombres = new string[n]; // Arreglo para nombres
        float[,] notas = new float[n, 3]; // Matriz para notas
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
            nombres[i] = Console.ReadLine();

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Ingrese la nota {j + 1} de {nombres[i]}: ");
                notas[i, j] = float.Parse(Console.ReadLine());
            }
        }
        float[] promedios = new float[n];
        int estudianteMejorPromedio = 0;
        for (int i = 0; i < n; i++)
        {
            float sumaNotas = 0;

            for (int j = 0; j < 3; j++)
            {
                sumaNotas += notas[i, j];
            }
            promedios[i] = sumaNotas / 3;
            string estado = promedios[i] >= 70 ? "Aprobado" : "Reprobado";
            Console.WriteLine($"\nEstudiante: {nombres[i]}");
            Console.WriteLine($"Notas: {notas[i, 0]}, {notas[i, 1]}, {notas[i, 2]}");
            Console.WriteLine($"Promedio: {promedios[i]:0.00} - {estado}");
            if (promedios[i] > promedios[estudianteMejorPromedio])
            {
                estudianteMejorPromedio = i;
            }
        }

        Console.WriteLine($"\nEl estudiante con el mejor promedio es {nombres[estudianteMejorPromedio]} con un promedio de {promedios[estudianteMejorPromedio]:0.00}.");
    }
}
