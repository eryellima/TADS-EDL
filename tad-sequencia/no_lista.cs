public class NoLista<T> {
    public T Elemento { get; set; }
    public NoLista<T> Anterior { get; set; }
    public NoLista<T> Proximo { get; set; }

    public NoLista(T elemento) {
        Elemento = elemento;
        Anterior = null;
        Proximo = null;
    }
}
