class Program
{
    static void Main()
    {
        PriorityQueueArray<int> pq = new PriorityQueueArray<int>(5);

        pq.Insert(5);
        pq.Insert(2);
        pq.Insert(8);
        pq.Insert(1);
        pq.Insert(7);

        Console.WriteLine($"Min: {pq.Min()}"); // Deve imprimir 1

        Console.WriteLine("Removendo o mínimo:");
        while (!pq.IsEmpty())
        {
            Console.WriteLine(pq.RemoveMin());
        }
    }
}