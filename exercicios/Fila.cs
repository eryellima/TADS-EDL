using System;
using System.Collections;

public class Fila<T>
{
    private ArrayList elementos = new ArrayList();
    
    // Adiciona o elemento à fila.
    public void Enqueue(T item)
    {
        elementos.Add(item);
    }

    // Remove e retornar o priemiro elemento da fila.
    public T Dequeue()
    {
        if (elementos.Count == 0)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        T item = (T)elementos[0];
        elementos.RemoveAt(0);
        return item;
    }

    // Retornar o primeiro elemento da fila sem removelo
    public T Peek()
    {
        if (elementos.Count == 0)
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        return (T)elementos[0];
    }

    // Retorna o Tamanho da fila.
    public int Count
    {
        get { 
            return elementos.Count;
        }
    }

    // Verifica se a fila es´ta vazia.
    public bool IsEmpty
    {
        get { 
            return elementos.Count == 0;
        }
    }
}
