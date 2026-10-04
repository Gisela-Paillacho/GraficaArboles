using System;

public class ArbolBinario
{
    public Nodo Raiz;

    public void Insertar(int valor)
    {
        Nodo nuevo = new Nodo(valor);

        if (Raiz == null)
        {
            Raiz = nuevo;
            return;
        }

        InsertarRecursivo(Raiz, nuevo);
    }

    private void InsertarRecursivo(Nodo actual, Nodo nuevo)
    {
        if (nuevo.Valor < actual.Valor)
        {
            if (actual.Izquierda == null)
            {
                actual.Izquierda = nuevo;
            }
            else
            {
                InsertarRecursivo(actual.Izquierda, nuevo);
            }
        }
        else
        {
            if (actual.Derecha == null)
            {
                actual.Derecha = nuevo;
            }
            else
            {
                InsertarRecursivo(actual.Derecha, nuevo);
            }
        }
    }

    public void RecorridoInorden()
    {
        RecorridoInordenRecursivo(Raiz);
    }

    private void RecorridoInordenRecursivo(Nodo actual)
    {
        if (actual != null)
        {
            RecorridoInordenRecursivo(actual.Izquierda);
            Console.Write(actual.Valor + " ");
            RecorridoInordenRecursivo(actual.Derecha);
        }
    }

    public void RecorridoPreorden()
    {
        RecorridoPreordenRecursivo(Raiz);
    }

    private void RecorridoPreordenRecursivo(Nodo actual)
    {
        if (actual != null)
        {
            Console.Write(actual.Valor + " ");
            RecorridoPreordenRecursivo(actual.Izquierda);
            RecorridoPreordenRecursivo(actual.Derecha);
        }
    }

    public void RecorridoPostorden()
    {
        RecorridoPostordenRecursivo(Raiz);
    }

    private void RecorridoPostordenRecursivo(Nodo actual)
    {
        if (actual != null)
        {
            RecorridoPostordenRecursivo(actual.Izquierda);
            RecorridoPostordenRecursivo(actual.Derecha);
            Console.Write(actual.Valor + " ");
        }
    }

    public bool Buscar(int valor)
    {
        Nodo actual = Raiz;

        while (actual != null)
        {
            if (valor == actual.Valor)
            {
                return true;
            }

            if (valor < actual.Valor)
            {
                actual = actual.Izquierda;
            }
            else
            {
                actual = actual.Derecha;
            }
        }

        return false;
    }
}