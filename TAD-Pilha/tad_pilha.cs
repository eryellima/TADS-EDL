puclic class Pilha<T> {
  private List<T> elementos;

  public Pilha() {
    elementos = new List<T>();
  }

  public void Push(T elemento) {
    if(IsEmpty()) {
      throw new InvalidOperationException("A pilha está vazia.");
    }

    int indice_Topo = elementos.Count - 1;
    T elemento_Removido = elementos[indice_Topo];
    elementos.RemoveAt(indice_Topo);
    return elemento_Removido;
  }

  public T Peek() {
    if(IsEmpty()) {
      throw new InvalidOperationException("A pilha está vazia.");
    }

    return elementos[elementos.Count - 1];
  }

  public bool IsEmpty() {
    return elementos.Count == 0;
  }

  public int Count() {
    return elementos.Count;
  }
}
