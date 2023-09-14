using System;
using System.Collections;


public class Fila<T> {
    private ArrayList elementos = new ArrayList();

    // para adicionar um elemento ao final da fila
    public void Enqueue(T item) {
        elementos.Add(item)
    }


    // para reomver o elemento no inicio da fila
    public T Dequeue() {
        if(elementos.Count == 0) {
            throw new InvalidOperationException("A fila está vazia.");
        }

        T item = (T)elementos[0];
        elementos.RemoveAt(0);
        return item;
    }


    public T Peek() {
        if(elementos.Count == 0) {
            throw new InvalidOperationException("A fila está vazia.");
        }

        return (T)elementos[0];
    }


    public int Count {
        get {
            return elemenotos.Count;
        }
    }


    public bool IsEmpty {
        get {
            return elementos.Count == 0;
        }
    }
}
