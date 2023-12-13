using System;

public class PriorityQueueArray<T> where T : IComparable<T>
{
    private T[] heapArray;
    private int size;

    public PriorityQueueArray(int capacity)
    {
        heapArray = new T[capacity + 1]; // Ignoramos o índice 0 para simplificar os cálculos
        size = 0;
    }

    
    // Método de inserçãoo
    public void Insert(T key)
    {
        if (size == heapArray.Length - 1)
        {
            // Expandir o array se necessário
            Array.Resize(ref heapArray, heapArray.Length * 2);
        }

        size++;
        heapArray[size] = key;
        UpHeap(size);
    }


    // Método para remover a menor chave
    public T RemoveMin()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A fila de prioridade está vazia.");
        }

        T min = heapArray[1];
        heapArray[1] = heapArray[size];
        size--;
        DownHeap(1);

        return min;
    }

    public T Min()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A fila de prioridade está vazia.");
        }

        return heapArray[1];
    }

    public int Size()
    {
        return size;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    // Método para reajustar o hepa na inserção
    private void UpHeap(int index)
    {
        while (index > 1)
        {
            int parentIndex = index / 2;
            if (heapArray[index].CompareTo(heapArray[parentIndex]) < 0)
            {
                Swap(index, parentIndex);
                index = parentIndex;
            }
            else
            {
                break;
            }
        }
    }

    private void DownHeap(int index)
    {
        while (2 * index <= size)
        {
            int leftChild = 2 * index;
            int rightChild = leftChild + 1;
            int smallerChild = leftChild;

            if (rightChild <= size && heapArray[rightChild].CompareTo(heapArray[leftChild]) < 0)
            {
                smallerChild = rightChild;
            }

            if (heapArray[index].CompareTo(heapArray[smallerChild]) > 0)
            {
                Swap(index, smallerChild);
                index = smallerChild;
            }
            else
            {
                break;
            }
        }
    }

    private void Swap(int i, int j)
    {
        T temp = heapArray[i];
        heapArray[i] = heapArray[j];
        heapArray[j] = temp;
    }
}
