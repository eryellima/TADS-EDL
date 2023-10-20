// Testes para o TAD Lista com array
class Program
{
    static void Main(string[] args)
    {
        TestTADListaArray();
    }

    static void TestTADListaArray()
    {
        TADListaArray<int> lista = new TADListaArray<int>(5);

        lista.InsertLast(10);
        lista.InsertLast(20);
        lista.InsertLast(30);
        lista.InsertLast(40);
        lista.InsertLast(50);
        lista.InsertLast(100);
        lista.InsertLast(150);
        lista.InsertLast(200);
        lista.InsertLast(250);

        Console.WriteLine("Size: " + lista.Size()); // Deve imprimir "Size: 2"
        Console.WriteLine("IsEmpty: " + lista.IsEmpty()); // Deve imprimir "IsEmpty: False"
        Console.WriteLine("First: " + lista.First()); // Deve imprimir "First: 1"
        Console.WriteLine("Last: " + lista.Last()); // Deve imprimir "Last: 2"
        Console.WriteLine("Before(1): " + lista.Before(1)); // Deve imprimir "Before(1): 1"
        Console.WriteLine("After(0): " + lista.After(0)); // Deve imprimir "After(0): 2"

        lista.ReplaceElement(0, 3);
        Console.WriteLine("ReplaceElement(0, 3): " + lista.First()); // Deve imprimir "ReplaceElement(0, 3): 3"

        lista.InsertBefore(0, 0);
        Console.WriteLine("InsertBefore(0, 0): " + lista.First()); // Deve imprimir "InsertBefore(0, 0): 0"

        lista.InsertAfter(1, 4);
        Console.WriteLine("InsertAfter(1, 4): " + lista.After(0)); // Deve imprimir "InsertAfter(1, 4): 4"

        lista.InsertFirst(-1);
        Console.WriteLine("InsertFirst(-1): " + lista.First()); // Deve imprimir "InsertFirst(-1): -1"

        lista.Remove(3);
        Console.WriteLine("Remove(3) - After(1): " + lista.After(0)); // Deve imprimir "Remove(3) - After(1): 4"
    }
}



// TEste para o TAD Lista utilizando o lista duplamente encadeada
/*
class Program
{
    static void Main(string[] args)
    {
        TestTADListaDuplamenteEncadeada();
    }

    static void TestTADListaDuplamenteEncadeada()
    {
        TADListaDuplamenteEncadeada<int> lista = new TADListaDuplamenteEncadeada<int>();

        // Testando size() e isEmpty()
        Console.WriteLine("Tamanho da lista (vazia): " + lista.Size());
        Console.WriteLine("Está vazia? (vazia): " + lista.IsEmpty());

        // Testando insertFirst() e insertLast()
        NoLista<int> primeiro = lista.InsertFirst(1);
        NoLista<int> segundo = lista.InsertLast(2);

        // Testando size() e isEmpty() após inserções
        Console.WriteLine("Tamanho da lista (após inserções): " + lista.Size());
        Console.WriteLine("Está vazia? (após inserções): " + lista.IsEmpty());

        // Testando First() e Last()
        Console.WriteLine("Primeiro elemento: " + lista.First().Elemento);
        Console.WriteLine("Último elemento: " + lista.Last().Elemento);

        // Testando Before() e After()
        Console.WriteLine("Elemento antes do segundo: " + lista.Before(segundo).Elemento);
        Console.WriteLine("Elemento após o primeiro: " + lista.After(primeiro).Elemento);

        // Testando ReplaceElement()
        lista.ReplaceElement(primeiro, 3);
        Console.WriteLine("Primeiro elemento após substituição: " + lista.First().Elemento);

        // Testando SwapElements()
        lista.SwapElements(primeiro, segundo);
        Console.WriteLine("Primeiro elemento após troca: " + lista.First().Elemento);
        Console.WriteLine("Segundo elemento após troca: " + lista.After(primeiro).Elemento);

        // Testando insertBefore() e insertAfter()
        NoLista<int> novoNo = lista.InsertBefore(segundo, 4);
        lista.InsertAfter(primeiro, 5);
        Console.WriteLine("Elemento antes do segundo após inserção: " + lista.Before(segundo).Elemento);
        Console.WriteLine("Elemento após o primeiro após inserção: " + lista.After(primeiro).Elemento);

        // Testando Remove()
        lista.Remove(novoNo);
        Console.WriteLine("Tamanho da lista após remoção: " + lista.Size());
        Console.WriteLine("Elemento após o primeiro após remoção: " + lista.After(primeiro).Elemento);
    }
}
*/
