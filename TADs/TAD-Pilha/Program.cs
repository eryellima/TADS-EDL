class Program{
    static void Main(){
        // Testando Pilha com array
        var pilhaArray = new PilhaArray<int>(5);

        Console.WriteLine("Pilha com Array!!!");
        Console.WriteLine("Pilha está vazia: " + pilhaArray.IsEmpty());
        Console.WriteLine("Pilha está cheia: " + pilhaArray.IsFull());

        Console.WriteLine("Adicionando {10, 20, 30, 40, 50} dentro da pilha!");

        pilhaArray.Push(10);
        pilhaArray.Push(20);
        pilhaArray.Push(30);
        pilhaArray.Push(40);
        pilhaArray.Push(50);

        Console.WriteLine("Topo atual da pilha: " + pilhaArray.Peek());

        Console.WriteLine("Removendo o topo!");
        pilhaArray.Pop();

        Console.WriteLine("Topo atual da pilha: " + pilhaArray.Peek());

        Console.WriteLine();

        // Testando Pilha com Lista Encadeada
        var pilhaLista = new PilhaLista<string>();

        Console.WriteLine("Pilha com Lista Encadeada!!!");
        Console.WriteLine("Pilha está vazia: " + pilhaLista.IsEmpty());

        Console.WriteLine("Adicionando {A, B, C, D, E} dentro da pilha!");

        pilhaLista.Push("A");
        pilhaLista.Push("B");
        pilhaLista.Push("C");
        pilhaLista.Push("D");
        pilhaLista.Push("E");

        Console.WriteLine("Topo atual da pilha: " + pilhaLista.Peek());

        Console.WriteLine("Removendo o topo!");
        pilhaLista.Pop();

        Console.WriteLine("Topo atual da pilha: " + pilhaLista.Peek());
    }
}
