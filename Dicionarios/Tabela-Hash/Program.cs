using System;


namespace TabelaHash{
    class Program{
        static void Main(){
            HashTable hashtable = new HashTable(10);

            hashtable.InsertElement(1, 100);
            hashtable.InsertElement(2, 200);
            hashtable.InsertElement(3, 300);
            hashtable.InsertElement(11, 1100);
            hashtable.InsertElement(12, 1200);
            hashtable.InsertElement(21, 2100);
            hashtable.InsertElement(22, 2200);
            hashtable.InsertElement(23, 2300);
            hashtable.InsertElement(24, 2400);
            hashtable.InsertElement(33, 3300);

            Console.WriteLine("Tamanho: " + hashtable.Size);
            Console.WriteLine("Está vazio: " + hashtable.IsEmpty());

            // Buscar elementos
            Console.WriteLine("Value for Key 2: " + hashtable.FindElement(2));
            Console.WriteLine("Value for Key 23: " + hashtable.FindElement(23));
            Console.WriteLine("Value for Key 99: " + hashtable.FindElement(99));

            // Remover elementos
            hashtable.Remove(2);
            hashtable.Remove(23);
            hashtable.Remove(99); // Tentando remover uma chave que não existe

            Console.WriteLine("Tamanho depois de remover: " + hashtable.Size);

            Console.WriteLine("Current Table:");
            hashtable.Print();
        }
    }
}
