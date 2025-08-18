class Program {
    static void Main(string[] args) {
        TADSequencia<int> sequencia = new TADSequencia<int>();

    Console.WriteLine("Tamanho da sequência (vazia): " + sequencia.Size()); // Deve imprimir "Tamanho da sequência (vazia): 0"
    Console.WriteLine("Está vazia? (vazia): " + sequencia.IsEmpty()); // Deve imprimir "Está vazia? (vazia): True"

    sequencia.InsertLast(1);
    sequencia.InsertLast(2);
    sequencia.InsertLast(3);

    Console.WriteLine("Tamanho da sequência (após inserções): " + sequencia.Size()); // Deve imprimir "Tamanho da sequência (após inserções): 3"
    Console.WriteLine("Está vazia? (após inserções): " + sequencia.IsEmpty()); // Deve imprimir "Está vazia? (após inserções): False"

    Console.WriteLine("Primeiro elemento: " + sequencia.First()); // Deve imprimir "Primeiro elemento: 1"
    Console.WriteLine("Último elemento: " + sequencia.Last()); // Deve imprimir "Último elemento: 3"

    Console.WriteLine("Elemento antes do segundo: " + sequencia.Before(sequencia.AtRank(1))); // Deve imprimir "Elemento antes do segundo: 1"
    Console.WriteLine("Elemento após o primeiro: " + sequencia.After(sequencia.AtRank(0))); // Deve imprimir "Elemento após o primeiro: 2"

    sequencia.ReplaceElements(sequencia.AtRank(0), sequencia.AtRank(1));
    Console.WriteLine("Primeiro elemento após substituição: " + sequencia.First()); // Deve imprimir "Primeiro elemento após substituição: 2"

    sequencia.SwapElements(sequencia.AtRank(0), sequencia.AtRank(1));
    Console.WriteLine("Primeiro elemento após troca: " + sequencia.First()); // Deve imprimir "Primeiro elemento após troca: 3"
    Console.WriteLine("Segundo elemento após troca: " + sequencia.After(sequencia.AtRank(0))); // Deve imprimir "Segundo elemento após troca: 2"

    sequencia.InsertBefore(sequencia.AtRank(1), 4);
    sequencia.InsertAfter(sequencia.AtRank(0), 5);
    sequencia.InsertFirst(6);
    sequencia.InsertLast(7);

    Console.WriteLine("Tamanho da sequência após inserção: " + sequencia.Size()); // Deve imprimir "Tamanho da sequência após inserção: 7"

    Console.WriteLine("Elemento após o primeiro após inserção: " + sequencia.After(sequencia.AtRank(0))); // Deve imprimir "Elemento após o primeiro após inserção: 5"

    sequencia.Remove(sequencia.AtRank(3));
    Console.WriteLine("Tamanho da sequência após remoção: " + sequencia.Size());
    }
}
