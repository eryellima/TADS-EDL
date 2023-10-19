using System;


class Pilha<T> {
  private T[] array;
  private int tamanho;
  private int t_vermelha;
  private int t_preta;

  
  public Pilha(int capacidade) {
    if(capacidade <= 0) {
      throw new ArgumentException("A capacidade deve ser maior que zero!");
    }

    array = new T[capacidade];
    tamanho = capacidade;
    t_vermelha = -1;
    t_preta = tamanho;
  }

  
  public void Push_Vermelha(T item) {
    if(t_vermelha + 1 == t_preta) {
      Redimensionar();
    }

    t_vermelha++;
    array[t_vermelha] = item;
  }

  
  public void Push_Preta(T item) {
    if(t_preta - 1 == t_vermelha) {
      Redimensionar();
    }

    t_preta--;
    array[t_preta] = item;
  }


  public T Pop_Vermelha() {
    if(t_vermelha == -1) {
      throw new InvalidOperationException("A pilha está vazia!");
    }

    T item = array[t_vermelha];
    t_vermelha--;
    return item;
  }

  
  public T Pop_Preta() {
    if(t_preta == tamanho) {
      throw new InvalidOperationException("A pilha está vazia!");
    }

    T item = array[t_preta];
    t_preta++;
    return item;
  }


  public T Top_Vermelha() {
    if(t_vermelha == -1) {
      throw new InvalidOperationException("A pilha está vazia!");
    }

    return array[t_vermelha];
  }


  public T Top_Preta() {
    if(t_preta == tamanho) {
      throw new InvalidOperationException("A pilha está vazia!");
    }

    return array[t_preta];
  }


  public int Size_Vermelha() {
    return t_vermelha + 1;
  }


  public int Size_Preta() {
    return tamanho - t_preta;
  }

  public void Redimensionar() {
    int nova_capacidade = tamanho * 2;
    T[] novo_array = new T[nova_capacidade];

    for(int i = 0; i <= t_vermelha; i++) {
      novo_array[i] = array[i];
    }

    int novo_t_preta = nova_capacidade - 1;

    for(int i = tamanho - 1; i >= t_preta; i--) {
      novo_array[novo_t_preta] = array[i];
      novo_t_preta--;
    }

    tamanho = nova_capacidade;
    t_preta = novo_t_preta;
    array = novo_array;
  }
}
