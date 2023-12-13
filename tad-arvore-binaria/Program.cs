class Program {
    static void Main() {
        // Criando a árvore binária de pesquisa
        ArvoreBinariaPesquisa<int> tree = new ArvoreBinariaPesquisa<int>();

        // Inserindo elementos
        tree.Insert(10);
        tree.Insert(5);
        tree.Insert(15);
        tree.Insert(2);
        tree.Insert(8);
        tree.Insert(22);
        tree.Insert(25);


        // Imprimindo a árvore
        tree.PrintTree();
        Console.WriteLine();

        // Procurando um nó
        int keyToFind = 5;
        Node<int> foundNode = tree.Find(keyToFind);
        Console.WriteLine($"Chave {keyToFind} encontrada: {foundNode != null}");
        Console.WriteLine();

        // Removendo um nó
        int keyToRemove = 5;
        tree.Remove(keyToRemove);
        Console.WriteLine($"Chave {keyToRemove} removida");
        Console.WriteLine();

        // Printando novamente a árvore sem a chave 5
        tree.PrintTree();
        Console.WriteLine();
    }
}
