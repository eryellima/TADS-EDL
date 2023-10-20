using System;

class Program
{
    static void Main(string[] args)
    {
        Pilha<int> pilhas = new Pilha<int>(10);

        pilhas.Push_Vermelha(1);
        pilhas.Push_Vermelha(2);
        pilhas.Push_Vermelha(3);
        pilhas.Push_Vermelha(4);
        pilhas.Push_Vermelha(5);
        
        pilhas.Push_Preta(10);
        pilhas.Push_Preta(20);
        pilhas.Push_Preta(30);
        pilhas.Push_Preta(40);

        int topo_Vermelha = pilhas.Top_Vermelha();
        int topo_Preta = pilhas.Top_Preta();

        int tamanho_Vermelha = pilhas.Size_Vermelha();
        int tamanho_Preta = pilhas.Size_Preta();

        Console.WriteLine("Topo da Pilha Vermelha: " + topo_Vermelha);
        Console.WriteLine("Topo da Pilha Preta: " + topo_Preta);

        Console.WriteLine("Tamanho da Pilha Vermelha: " + tamanho_Vermelha);
        Console.WriteLine("Tamanho da Pilha Preta: " + tamanho_Preta);

        Console.WriteLine("Pilha Vermelha:");
        while (true)
        {
            try
            {
                int item = pilhas.Pop_Vermelha();
                Console.WriteLine(item);
            }
            catch (InvalidOperationException)
            {
                break;
            }
        }

        Console.WriteLine("Pilha Preta:");
        while (true)
        {
            try
            {
                int item = pilhas.Pop_Preta();
                Console.WriteLine(item);
            }
            catch (InvalidOperationException)
            {
                break;
            }
        }
    }
}
