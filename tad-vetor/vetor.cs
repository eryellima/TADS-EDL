using System;


public class Vetor<T> {
  private T[] array;
  private int n;

  public Vetor(int capacidade) {
    array = new T[capacidad];
    n = 0;
  }


  public T ElementAtRank(int r) {
    if(r < 0 || r >= n) {
      throw new IndexOutRangeException("Colocação Incorreta.");
    }

    return array[r];
  }


  public T ReplaceAtRank(int r, T element){
    if(r < 0 || r >= n) {
      throw new IndexOutRangeException("Colocação Incorreta.");
    }

    T oldElement = array[r];
    array[r] = element;
    return oldElement;
  }

  
  public void InsertAtRank(int r, T element) {
    if(r < 0 || r >= n) {
      throw new IndexOutRangeException("Colocação Incorreta.");
    }

    if(n == array.Length) {
      ResizeArray();
    }

    for(int i = n; i > r; i--) {
      array[i] = array[i - 1];
    }

    array[r] = element;
    n++;
  }


  public T RemoveAtRank(int r) {
    if(r < 0 || r >= n) {
      throw new IndexOutRangeException("Colocação Incorreta.");
    }

    T removedElement = array[r];

    for(int i = r; i < n - 1; i++) {
      array[i] = array[i + 1];
    }

    n--;
    return removedElement;
  }


  public int Size() {
    return n;
  }


  public bool IsEmpty() {
    return n == 0;
  }


  public void ResizeArray() {
    int newCapacidade = (array.Length == 0) ? 1 : array.Length * 2;
    T[] newArray = new T[newCapacidade];

    for(int i = 0; i < n; i++) {
      newArray[i] = array[i];
    }

    array = newArray;
  } 
}
