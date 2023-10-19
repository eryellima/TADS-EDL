using System;
class Program {
  static void Main(string[] args) {
    TestElemAtRank();
    TestReplaceAtRank();
    TestInsertAtRank();
    TestRemoveAtRank();
    TestSizeAndIsEmpty();
  }
  static void TestElemAtRank() {
    VetorArray<int> vetor = new VetorArray<int>(5);
    vetor.InsertAtRank(0, 1);
    vetor.InsertAtRank(1, 2);
    
    // Testando o método ElemAtRank
    int element = vetor.ElemAtRank(0);
    
    // imprimir "ElemAtRank(0): 1"
    Console.WriteLine("ElemAtRank(0): " + element);
  }
  static void TestReplaceAtRank() {
    VetorArray<int> vetor = new VetorArray<int>(5);
    vetor.InsertAtRank(0, 1);
    vetor.InsertAtRank(1, 2);
    
    // Testando o método ReplaceAtRank
    int oldElement = vetor.ReplaceAtRank(1, 3);
    
    // imprimir "ReplaceAtRank(1, 3): 2"
    Console.WriteLine("ReplaceAtRank(1, 3): " + oldElement);
  }
  static void TestInsertAtRank() {
    VetorArray<int> vetor = new VetorArray<int>(5);
    
    // Testando o método InsertAtRank
    vetor.InsertAtRank(0, 1);
    vetor.InsertAtRank(0, 2);
    
    // imprimir "ElemAtRank(0): 2"
    Console.WriteLine("ElemAtRank(0): " + vetor.ElemAtRank(0));
  }
  static void TestRemoveAtRank() {
    VetorArray<int> vetor = new VetorArray<int>(5);
    vetor.InsertAtRank(0, 1);
    vetor.InsertAtRank(1, 2);
    vetor.InsertAtRank(2, 3);
    
    // Testando o método RemoveAtRank
    int removedElement = vetor.RemoveAtRank(1);
    
    // Deve imprimir "RemoveAtRank(1): 2"
    Console.WriteLine("RemoveAtRank(1): " + removedElement);
    
    // Deve imprimir "ElemAtRank(1): 3"
    Console.WriteLine("ElemAtRank(1): " + vetor.ElemAtRank(1));
  }
  static void TestSizeAndIsEmpty() {
    VetorArray<int> vetor = new VetorArray<int>(5);
    // imprimir "Tamanho do Vetor (vazio): 0"
    Console.WriteLine("Tamanho do Vetor (vazio): " + vetor.Size());
    
    // imprimir "Está vazio? (vazio): True"
    Console.WriteLine("Está vazio? (vazio): " + vetor.IsEmpty());
    
    vetor.InsertAtRank(0, 1);
    vetor.InsertAtRank(1, 2);
    
    // Deve imprimir "Tamanho do Vetor (após inserção): 2"
    Console.WriteLine("Tamanho do Vetor (após inserção): " + vetor.Size());
    
    // imprimir "Está vazio? (após inserção): False"
    Console.WriteLine("Está vazio? (após inserção): " + vetor.IsEmpty());
  }
}
