using System;

class Program
{
    static void Main()
    {
        // Criação de alguns nós de exemplo
        Node<int> node1 = new Node<int>(5);
        Node<int> node2 = new Node<int>(3);
        Node<int> node3 = new Node<int>(7);
        Node<int> node4 = new Node<int>(2);
        Node<int> node5 = new Node<int>(8);

        // Criação da fila de prioridade
        PriorityQueue<int> priorityQueue = new PriorityQueue<int>();

        // Inserção de nós na fila de prioridade
        priorityQueue.Insert(node1);
        priorityQueue.Insert(node2);
        priorityQueue.Insert(node3);
        priorityQueue.Insert(node4);
        priorityQueue.Insert(node5);

        // Teste dos métodos
        Console.WriteLine($"Tamanho da fila de prioridade: {priorityQueue.Size()}");
        Console.WriteLine($"Mínimo na fila de prioridade: {priorityQueue.Min().Key}");

        // Remoção do menor elemento
        Node<int> removedNode = priorityQueue.RemoveMin();
        Console.WriteLine($"Nó removido: {removedNode.Key}");

        Console.WriteLine($"Tamanho da fila de prioridade após remoção: {priorityQueue.Size()}");
        Console.WriteLine($"Novo mínimo na fila de prioridade: {priorityQueue.Min().Key}");
    }
}
