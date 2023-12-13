using System;
using System.Collections.Generic;

public class PriorityQueue<T> where T : IComparable<T>
{
    private List<Node<T>> heap;

    public PriorityQueue()
    {
        heap = new List<Node<T>>();
    }

    public void Insert(Node<T> node)
    {
        heap.Add(node);
        UpHeap(heap.Count - 1);
    }

    public Node<T> RemoveMin()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("PriorityQueue is empty");
        }

        Node<T> min = heap[0];
        int lastIdx = heap.Count - 1;
        heap[0] = heap[lastIdx];
        heap.RemoveAt(lastIdx);

        if (heap.Count > 1)
        {
            DownHeap(0);
        }

        return min;
    }

    public Node<T> Min()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("PriorityQueue is empty");
        }

        return heap[0];
    }

    public int Size()
    {
        return heap.Count;
    }

    public bool IsEmpty()
    {
        return heap.Count == 0;
    }

    private void UpHeap(int index)
    {
        while (index > 0)
        {
            int parentIdx = (index - 1) / 2;
            if (heap[index].Key.CompareTo(heap[parentIdx].Key) < 0)
            {
                Swap(index, parentIdx);
                index = parentIdx;
            }
            else
            {
                break;
            }
        }
    }

    private void DownHeap(int index)
    {
        int leftChildIdx;
        int rightChildIdx;
        int smallestChildIdx;

        while (true)
        {
            leftChildIdx = 2 * index + 1;
            rightChildIdx = 2 * index + 2;
            smallestChildIdx = index;

            if (leftChildIdx < heap.Count && heap[leftChildIdx].Key.CompareTo(heap[smallestChildIdx].Key) < 0)
            {
                smallestChildIdx = leftChildIdx;
            }

            if (rightChildIdx < heap.Count && heap[rightChildIdx].Key.CompareTo(heap[smallestChildIdx].Key) < 0)
            {
                smallestChildIdx = rightChildIdx;
            }

            if (smallestChildIdx != index)
            {
                Swap(index, smallestChildIdx);
                index = smallestChildIdx;
            }
            else
            {
                break;
            }
        }
    }

    private void Swap(int i, int j)
    {
        Node<T> temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}
