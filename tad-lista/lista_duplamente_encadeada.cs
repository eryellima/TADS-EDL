public class TADListaDuplamenteEncadeada<T> {
    private NoLista<T> Primeiro;
    private NoLista<T> Ultimo;
    private int Tamanho;

    public TADListaDuplamenteEncadeada() {
        Primeiro = null;
        Ultimo = null;
        Tamanho = 0;
    }

    public int Size() {
        return Tamanho;
    }

    public bool IsEmpty() {
        return Tamanho == 0;
    }

    public bool IsFirst(NoLista<T> n) {
        return n == Primeiro;
    }

    public bool IsLast(NoLista<T> n) {
        return n == Ultimo;
    }

    public NoLista<T> First() {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A lista está vazia.");
        }

        return Primeiro;
    }

    public NoLista<T> Last() {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A lista está vazia.");
        }

        return Ultimo;
    }

    public NoLista<T> Before(NoLista<T> n) {
        return n.Anterior;
    }

    public NoLista<T> After(NoLista<T> n) {
        return n.Proximo;
    }

    public void ReplaceElement(NoLista<T> n, T elemento) {
        n.Elemento = elemento;
    }

    public void SwapElements(NoLista<T> n, NoLista<T> q) {
        T temp = n.Elemento;
        n.Elemento = q.Elemento;
        q.Elemento = temp;
    }

    public NoLista<T> InsertBefore(NoLista<T> n, T elemento) {
        NoLista<T> novoNo = new NoLista<T>(elemento, n.Anterior, n);

        if (n == Primeiro) {
            Primeiro = novoNo;
        } else {
            n.Anterior.Proximo = novoNo;
        }

        n.Anterior = novoNo;
        Tamanho++;

        return novoNo;
    }

    public NoLista<T> InsertAfter(NoLista<T> n, T elemento) {
        NoLista<T> novoNo = new NoLista<T>(elemento, n, n.Proximo);

        if (n == Ultimo) {
            Ultimo = novoNo;
        } else {
            n.Proximo.Anterior = novoNo;
        }

        n.Proximo = novoNo;
        Tamanho++;

        return novoNo;
    }

    public NoLista<T> InsertFirst(T elemento) {
        if (IsEmpty()) {
            Primeiro = Ultimo = new NoLista<T>(elemento);
        } else {
            Primeiro.Anterior = new NoLista<T>(elemento, null, Primeiro);
            Primeiro = Primeiro.Anterior;
        }

        Tamanho++;

        return Primeiro;
    }

    public NoLista<T> InsertLast(T elemento) {
        if (IsEmpty()) {
            Primeiro = Ultimo = new NoLista<T>(elemento);
        } else {
            Ultimo.Proximo = new NoLista<T>(elemento, Ultimo, null);
            Ultimo = Ultimo.Proximo;
        }

        Tamanho++;

        return Ultimo;
    }

    public void Remove(NoLista<T> n) {
        if (n == Primeiro) {
            Primeiro = n.Proximo;
        } else {
            n.Anterior.Proximo = n.Proximo;
        }

        if (n == Ultimo) {
            Ultimo = n.Anterior;
        } else {
            n.Proximo.Anterior = n.Anterior;
        }

        Tamanho--;
    }
}
