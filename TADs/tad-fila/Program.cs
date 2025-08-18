using System;


class Program {
    static void Main(string[] args) {
        Fila fila = new Fila(5);

        // Deve imprimir "True"
        Console.WriteLine("A fila está vazia? " + fila.EstaVazia());

        fila.Enqueue(1);
        fila.Enqueue(2);
        fila.Enqueue(3);

        // Deve imprimir "1"
        Console.WriteLine("Primeiro elemento da fila: " + fila.First());

        //Imprime "3"
        Console.WriteLine("Tamanho da fila: " + fila.Tamanho());

        fila.Enqueue(4);
        fila.Enqueue(5);

        // Imprime "5"
        Console.WriteLine("Tamanho da fila: " + fila.Tamanho());

        // Faz a fila redimensionar
        fila.Enqueue(6);

        // Imprime o 6
        Console.WriteLine("Tamanho da fila após redimensionar: " + fila.Tamanho());

        while (!fila.EstaVazia()) {
            Console.WriteLine("Removendo: " + fila.Dequeue());
        }

        // Deve imprimir "True"
        Console.WriteLine("A fila está vazia? " + fila.EstaVazia());

        try{
            Console.WriteLine("Primeiro elemento da fila: " + fila.First());
        } catch (EFilaVazia ex) {
            // Imprime que a fila está vazia
            Console.WriteLine(ex.Message);
        }
    }
}
