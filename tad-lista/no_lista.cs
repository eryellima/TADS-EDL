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
