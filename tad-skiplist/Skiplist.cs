using System;

public class SkipList<T> where T : IComparable<T>{
    private readonly SkipNode<T> head;
    private readonly Random random;
    private int height;

    public SkipList(){
        head = new SkipNode<T>(default, null);
        random = new Random();
        height = 0;
    }


    // Método para buscar uma chave
    public object Search(T key){
        SkipNode<T> current = head;

        while (current != null){
            while (current.Next != null && current.Next.Key.CompareTo(key) <= 0){
                current = current.Next;
            }

            if (current.Key.Equals(key)){
                return current.Value;
            }

            current = current.Down;
        }

        return null;
    }


    // Método para inse5rir uma chave
    public void Insert(T key, object value){
        SkipNode<T>[] update = new SkipNode<T>[height + 1];
        SkipNode<T> current = head;

        for (int i = height; i >= 0; i--){
            while (current.Next != null && current.Next.Key.CompareTo(key) < 0){
                current = current.Next;
            }

            update[i] = current;

            if (i > 0 && current.Down != null){
                current = current.Down;
            }
        }

        int newHeight = 0;

        while (random.Next(2) == 0){
            newHeight++;

            if (newHeight > height){
                height++;
                Array.Resize(ref update, height + 1);
                update[height] = head;
            }

            SkipNode<T> newNode = new SkipNode<T>(key, value){
                Next = update[newHeight].Next,
                Prev = update[newHeight],
                Down = newHeight > 0 ? update[newHeight - 1].Next : null
            };

            if (newNode.Next != null){
                newNode.Next.Prev = newNode;
            }

            update[newHeight].Next = newNode;
        }
    }


    // Método para remover uma chave
    public void Remove(T key){
        SkipNode<T> current = head;

        for (int i = height; i >= 0; i--){
            while (current.Next != null && current.Next.Key.CompareTo(key) < 0){
                current = current.Next;
            }

            if (current.Next != null && current.Next.Key.Equals(key)){
                current.Next = current.Next.Next;

                if (current.Next != null){
                    current.Next.Prev = current;
                }
            }

            if (i > 0 && current.Down != null){
                current = current.Down;
            }
        }

        
        while (height > 0 && head.Next == null){
            head.Down = head.Down?.Next;
            height--;
        }
    }

    public void PrintSkipList(){
        SkipNode<T> current = head;

        while (current != null){
            SkipNode<T> rowStart = current;

            while (current != null){
                Console.Write($"{current.Key} -> ");
                current = current.Next;
            }

            Console.WriteLine("null");
            current = rowStart.Down;
        }

        Console.WriteLine();
    }
}
