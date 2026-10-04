using System;
using System.IO;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch tiempo = Stopwatch.StartNew();

        // ==============================
        // PRIMER ÁRBOL
        // ==============================

        ArbolBinario arbol1 = new ArbolBinario();

        string[] datos1 = File.ReadAllLines("datos_arbol.txt");

        foreach (string dato in datos1)
        {
            int valor = int.Parse(dato);
            arbol1.Insertar(valor);
        }

        Console.WriteLine("================================");
        Console.WriteLine("       PRIMER ÁRBOL");
        Console.WriteLine("================================");
        Console.WriteLine();

        Console.WriteLine("Datos del primer árbol:");
        foreach (string dato in datos1)
        {
            Console.Write(dato + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Recorrido en orden:");
        arbol1.RecorridoInorden();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Recorrido en preorden:");
        arbol1.RecorridoPreorden();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Recorrido en postorden:");
        arbol1.RecorridoPostorden();

        Console.WriteLine();
        Console.WriteLine();


        // ==============================
        // SEGUNDO ÁRBOL
        // ==============================

        ArbolBinario arbol2 = new ArbolBinario();

        string[] datos2 = File.ReadAllLines("datos_arbol2.txt");

        foreach (string dato in datos2)
        {
            int valor = int.Parse(dato);
            arbol2.Insertar(valor);
        }

        Console.WriteLine("================================");
        Console.WriteLine("       SEGUNDO ÁRBOL");
        Console.WriteLine("================================");
        Console.WriteLine();

        Console.WriteLine("Datos del segundo árbol:");
        foreach (string dato in datos2)
        {
            Console.Write(dato + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Recorrido en orden:");
        arbol2.RecorridoInorden();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Recorrido en preorden:");
        arbol2.RecorridoPreorden();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Recorrido en postorden:");
        arbol2.RecorridoPostorden();

        Console.WriteLine();
        Console.WriteLine();


        // ==============================
        // CONSULTA DE ELEMENTOS
        // ==============================

        Console.WriteLine("================================");
        Console.WriteLine("      CONSULTA DE ELEMENTOS");
        Console.WriteLine("================================");
        Console.WriteLine();

        Console.Write("Ingrese un número para buscar: ");
        int consulta = int.Parse(Console.ReadLine());

        Console.WriteLine();

        if (arbol1.Buscar(consulta))
        {
            Console.WriteLine("El elemento se encuentra en el PRIMER ÁRBOL.");
        }
        else
        {
            Console.WriteLine("El elemento NO se encuentra en el PRIMER ÁRBOL.");
        }

        if (arbol2.Buscar(consulta))
        {
            Console.WriteLine("El elemento se encuentra en el SEGUNDO ÁRBOL.");
        }
        else
        {
            Console.WriteLine("El elemento NO se encuentra en el SEGUNDO ÁRBOL.");
        }

        tiempo.Stop();

        Console.WriteLine();
        Console.WriteLine("================================");
        Console.WriteLine("      TIEMPO DE EJECUCIÓN");
        Console.WriteLine("================================");
        Console.WriteLine("Tiempo: " + tiempo.ElapsedMilliseconds + " ms");
    }
}