using System;

class Program {
    static void Main(string[] args) {
        ArvoreSimples<int> arvore = new ArvoreSimples<int>(0);

        // Adicionando elementos na árvore
        var raiz = arvore.Root();
        
        var no1 = arvore.AddChild(raiz, 1);
        var no3 = arvore.AddChild(no1, 3);
        var no5 = arvore.AddChild(no1, 5);
        var no7 = arvore.AddChild(no5, 7);

        var no2 = arvore.AddChild(raiz, 2);
        var no4 = arvore.AddChild(no2, 4);
        var no6 = arvore.AddChild(no2, 6);
        var no8 = arvore.AddChild(no6, 8);
        
        

        // Tentando "desenhar" a árvore
        Console.WriteLine("----- Desenho da Árvore -----");
        arvore.PrintTree(arvore.Root());
        Console.WriteLine();


        Console.WriteLine("----- Altura da Árvore -----");
        Console.WriteLine(arvore.Height());
        Console.WriteLine();


        Console.WriteLine("----- Elemenotos da Árvore -----");
        foreach (int elemento in arvore.Elements()) {
            Console.WriteLine(elemento);
        }
        Console.WriteLine();


        Console.WriteLine("----- Nós da árvore -----");
        foreach (var no in arvore.Nodes()) {
            Console.WriteLine(no.Element);
        }
        Console.WriteLine();


        /* // Substituindo um elemento na árvore
        arvore.Replace(no3, 10);
        Console.WriteLine("----- Substituindo Nó 3 -----");
        Console.WriteLine("Novo elemento do nó 3: " + no3.Element);
        Console.WriteLine();

        Console.WriteLine("----- Desenho da Árvore com Subistituição do nó 3 -----");
        arvore.PrintTree(arvore.Root());
        Console.WriteLine(); */

        // Verificando se o nó é raiz, interno ou externo
        Console.WriteLine("----- Verificando Nó raiz, internos e externos -----");
        Console.WriteLine("Nó 1 é raiz: " + arvore.IsRoot(no1));
        Console.WriteLine("Nó 1 é interno: " + arvore.IsInternal(no1));
        Console.WriteLine("Nó 1 é externo: " + arvore.IsExternal(no1));
    }
}
