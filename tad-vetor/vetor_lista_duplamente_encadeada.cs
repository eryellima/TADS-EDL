using System;
  public class VetorListaDuplamenteEncadeada<T> {
  
  private NoLista<T> Primeiro;
  private NoLista<T> Ultimo;
  private int Tamanho;
  
  public VetorListaDuplamenteEncadeada() {
    Primeiro = null;
    Ultimo = null;
    Tamanho = 0;
  }

    
  public T ElemAtRank(int r) {
    if (r < 0 || r >= Tamanho) {
      throw new IndexOutOfRangeException("Colocação incorreta.");
    }

    NoLista<T> noAtual = GetNoAtRank(r);
    return noAtual.Elemento;
  }

    
  public T ReplaceAtRank(int r, T element) {
    if (r < 0 || r >= Tamanho) {
      throw new IndexOutOfRangeException("Colocação incorreta.");
    }

    NoLista<T> noAtual = GetNoAtRank(r);

    T oldElement = noAtual.Elemento;
    noAtual.Elemento = element;
    return oldElement;
  }
    
 
  public void InsertAtRank(int r, T element) {
    if (r < 0 || r > Tamanho) {
      throw new IndexOutOfRangeException("Colocação incorreta.");
    }
    
    if (r == 0) {
      InsertFirst(element);
    } else if (r == Tamanho) {
        InsertLast(element);
    } else {
      NoLista<T> noAtual = GetNoAtRank(r);
      NoLista<T> novoNo = new NoLista<T>(element, noAtual.Anterior, noAtual);
      noAtual.Anterior.Proximo = novoNo;
      noAtual.Anterior = novoNo;
      Tamanho++;
    }
  }

    
  public T RemoveAtRank(int r) {
    if (r < 0 || r >= Tamanho) {
      throw new IndexOutOfRangeException("Colocação incorreta.");
    }

    NoLista<T> noAtual = GetNoAtRank(r);

    if (noAtual == Primeiro) {
      Primeiro = noAtual.Proximo;
    } else {
      noAtual.Anterior.Proximo = noAtual.Proximo;
    }

    if (noAtual == Ultimo) {
      Ultimo = noAtual.Anterior;
    } else {
      noAtual.Proximo.Anterior = noAtual.Anterior;
    }
  
    Tamanho--;
    return noAtual.Elemento;
  }

    
  public int Size() {
    return Tamanho;
  }

    
  public bool IsEmpty() {
    return Tamanho == 0;
  }

  
  private void InsertFirst(T element) {
    NoLista<T> novoNo = new NoLista<T>(element, null, Primeiro);

    if (IsEmpty()) {
      Ultimo = novoNo;
    } else {
      Primeiro.Anterior = novoNo;
    }

    Primeiro = novoNo;
    Tamanho++;
  }

    
  private void InsertLast(T element) {
    NoLista<T> novoNo = new NoLista<T>(element, Ultimo, null);
    if (IsEmpty()) {
      Primeiro = novoNo;
    } else {
      Ultimo.Proximo = novoNo;
    }

    Ultimo = novoNo;
    Tamanho++;
  }

    
  private NoLista<T> GetNoAtRank(int r) {
    if (r < 0 || r >= Tamanho) {
      throw new IndexOutOfRangeException("Colocação incorreta.");
    }

    NoLista<T> noAtual = Primeiro;

    for (int i = 0; i < r; i++) {
      noAtual = noAtual.Proximo;
    }

    return noAtual;
  }
}
public class NoLista<T> {
  public T Elemento { get; set; }
  public NoLista<T> Anterior { get; set; }
  public NoLista<T> Proximo { get; set; }
  public NoLista(T elemento, NoLista<T> anterior = null, NoLista<T> proximo = null) {
    Elemento = elemento;
    Anterior = anterior;
    Proximo = proximo;
  }
}
