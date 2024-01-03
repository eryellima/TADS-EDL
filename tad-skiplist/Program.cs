using System;

class Program{
    static void Main(){
        // Testando a Skip List
        SkipList<int> skipList = new SkipList<int>();

        // Inserindo elementos
        skipList.Insert(3, "Três");
        skipList.Insert(1, "Um");
        skipList.Insert(4, "Quatro");
        skipList.Insert(2, "Dois");
        skipList.Insert(5, "Cinco");

        // Imprimindo a Skip List após inserção
        Console.WriteLine("Skip List após inserção:");
        skipList.PrintSkipList();

        // Buscando elementos
        Console.WriteLine("\nBuscando elementos:");
        Console.WriteLine("Chave 2: " + skipList.Search(2));
        Console.WriteLine("Chave 6: " + skipList.Search(6));

        // Removendo elementos
        skipList.Remove(2);
        skipList.Remove(5);

        // Imprimindo a Skip List após remoção
        Console.WriteLine("\nSkip List após remoção:");
        skipList.PrintSkipList();
    }
}
