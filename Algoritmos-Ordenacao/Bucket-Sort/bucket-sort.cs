using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        int[] array = { 10, 12, 15, 9, 5, 3, 20, 21, 31, 35, 37, 25 };

        Console.WriteLine("Lista não ordenada:");
        PrintArray(array);

        BucketSort(array);

        Console.WriteLine("Lista Ordenada:");
        PrintArray(array);
    }

    static void BucketSort(int[] array){
        if (array.Length <= 0)
            return;

        // Encontando o valor Min e Max
        int minValue = array[0];
        int maxValue = array[0];
        foreach (var item in array){
            if (item < minValue)
                minValue = item;
            if (item > maxValue)
                maxValue = item;
        }

        // criando os baldes
        int bucketCount = (int)Math.Ceiling(Math.Sqrt(array.Length));
        List<int>[] buckets = new List<int>[bucketCount];
        for (int i = 0; i < bucketCount; i++){
            buckets[i] = new List<int>();
        }

        // calculando o intervalo
        int range = (maxValue - minValue) / bucketCount + 1;

        // Distribuindo os elementos
        foreach (var item in array){
            int bucketIndex = (item - minValue) / range;
            buckets[bucketIndex].Add(item);
        }

        // tentativa de mostrar os baldes antes da ordenação
        Console.WriteLine("Baldes antes da ordenação:");
        PrintBuckets(buckets);

        // Ordenando os baldes
        int index = 0;
        foreach (var bucket in buckets){
            InsertionSort(bucket);
            foreach(var item in bucket){
                array[index++] = item;
            }
        }

        // tentativa de mostrar os baldes antes da ordenação
        Console.WriteLine("Baldes depois da ordenação:");
        PrintBuckets(buckets);
    }


    static void InsertionSort(List<int> list){
        for(int i = 1; i < list.Count; i++){
            int key = list[i];
            int j = i - 1;

            // Mvendo os elementos que são maiores que a chave para a direita
            while(j >= 0 && list[j] > key){
                list[j + 1] = list[j];
                j--;
            }
            
            list[j + 1] = key;
        }
    }

    static void PrintArray(int[] array){
        foreach (var item in array){
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void PrintBuckets(List<int>[] buckets){
        int bucketIndex = 1;
        foreach(var bucket in buckets){
            Console.Write($"Balde {bucketIndex}: ");
            if(bucket.Count == 0){
                Console.Write("Vazio");
            } else{
                Console.Write(string.Join(", ", bucket));
            }

            Console.WriteLine();
            bucketIndex++;
        }
    }
}
