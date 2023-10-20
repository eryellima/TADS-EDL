public class TADSequencia<T> {
    private NoLista<T> Primeiro;
    private NoLista<T> Ultimo;
    private int Tamanho;

    public TADSequencia() {
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

    public T ElemAtRank(int r) {
        if (r < 0 || r >= Tamanho) {
            throw new IndexOutOfRangeException("Colocação incorreta.");
        }

        // Percorre a lista para encontrar o elemento na posição r
        NoLista<T> atual = Primeiro;
        for (int i = 0; i < r; i++) {
            atual = atual.Proximo;
        }

        return atual.Elemento;
    }

    public T ReplaceAtRank(int r, T elemento) {
        if (r < 0 || r >= Tamanho) {
            throw new IndexOutOfRangeException("Colocação incorreta.");
        }

        // percorre a lista para encontrar o elemento na posição r
        NoLista<T> atual = Primeiro;
        for (int i = 0; i < r; i++) {
            atual = atual.Proximo;
        }

        T oldElement = atual.Elemento;
        atual.Elemento = elemento;
        return oldElement;
    }

    public void InsertAtRank(int r, T elemento) {
        if (r < 0 || r > Tamanho) {
            throw new IndexOutOfRangeException("Colocação incorreta.");
        }

        var novoNo = new NoLista<T>(elemento);

        if (Tamanho == 0) {
            Primeiro = novoNo;
            Ultimo = novoNo;
        } else if (r == 0) {
            novoNo.Proximo = Primeiro;
            Primeiro.Anterior = novoNo;
            Primeiro = novoNo;
        } else if (r == Tamanho) {
            novoNo.Anterior = Ultimo;
            Ultimo.Proximo = novoNo;
            Ultimo = novoNo;
        } else {
            // Percorre a lista para encontrar o nó na posição r
            NoLista<T> atual = Primeiro;
            for (int i = 0; i < r; i++) {
                atual = atual.Proximo;
            }

            novoNo.Anterior = atual.Anterior;
            novoNo.Proximo = atual;
            atual.Anterior.Proximo = novoNo;
            atual.Anterior = novoNo;
        }

        Tamanho++;
    }

    public T RemoveAtRank(int r) {
        if (r < 0 || r >= Tamanho) {
            throw new IndexOutOfRangeException("Colocação incorreta.");
        }

        if (Tamanho == 0) {
            throw new InvalidOperationException("A lista está vazia.");
        }

        NoLista<T> atual = Primeiro;
        for (int i = 0; i < r; i++) {
            atual = atual.Proximo;
        }

        T removedElement = atual.Elemento;

        if (r == 0) {
            Primeiro = atual.Proximo;
            if (Primeiro != null) {
                Primeiro.Anterior = null;
            }
        } else if (r == Tamanho - 1) {
            Ultimo = atual.Anterior;
            if (Ultimo != null) {
                Ultimo.Proximo = null;
            }
        } else {
            atual.Anterior.Proximo = atual.Proximo;
            atual.Proximo.Anterior = atual.Anterior;
        }

        Tamanho--;
        return removedElement;
    }

    public T First() {
    if (IsEmpty()) {
        throw new InvalidOperationException("A sequência está vazia.");
    }

    return Primeiro.Elemento;
    }

    public T Last() {
        if (IsEmpty()) {
            throw new InvalidOperationException("A sequência está vazia.");
        }

        return Ultimo.Elemento;
    }

    public T Before(NoLista<T> n) {
        if (n == Primeiro) {
            throw new InvalidOperationException("Não há elemento antes do primeiro.");
        }

        return n.Anterior.Elemento;
    }

    public T After(NoLista<T> n) {
        if (n == Ultimo) {
            throw new InvalidOperationException("Não há elemento após o último.");
        }

        return n.Proximo.Elemento;
    }

    public void ReplaceElements(NoLista<T> n, NoLista<T> q) {
        T temp = n.Elemento;
        n.Elemento = q.Elemento;
        q.Elemento = temp;
    }

    public void SwapElements(NoLista<T> n, NoLista<T> q) {
        T temp = n.Elemento;
        n.Elemento = q.Elemento;
        q.Elemento = temp;
    }

    public void InsertBefore(NoLista<T> n, T elemento) {
        NoLista<T> novoNo = new NoLista<T>(elemento);

        novoNo.Anterior = n.Anterior;
        novoNo.Proximo = n;
        n.Anterior.Proximo = novoNo;
        n.Anterior = novoNo;

        Tamanho++;
    }

    public void InsertAfter(NoLista<T> n, T elemento) {
        NoLista<T> novoNo = new NoLista<T>(elemento);

        novoNo.Anterior = n;
        novoNo.Proximo = n.Proximo;
        n.Proximo.Anterior = novoNo;
        n.Proximo = novoNo;

        Tamanho++;
    }

    public void InsertFirst(T elemento) {
        NoLista<T> novoNo = new NoLista<T>(elemento);

        if (IsEmpty()) {
            Primeiro = novoNo;
            Ultimo = novoNo;
        }
        else {
            novoNo.Proximo = Primeiro;
            Primeiro.Anterior = novoNo;
            Primeiro = novoNo;
        }

        Tamanho++;
    }

    public void InsertLast(T elemento) {
        NoLista<T> novoNo = new NoLista<T>(elemento);

        if (IsEmpty()) {
            Primeiro = novoNo;
            Ultimo = novoNo;
        }
        else {
            novoNo.Anterior = Ultimo;
            Ultimo.Proximo = novoNo;
            Ultimo = novoNo;
        }

        Tamanho++;
    }

    public void Remove(NoLista<T> n) {
        if (n == Primeiro) {
            Primeiro = n.Proximo;
            if (Primeiro != null)
            {
                Primeiro.Anterior = null;
            }
        } else if (n == Ultimo) {
            Ultimo = n.Anterior;
            if (Ultimo != null)
            {
                Ultimo.Proximo = null;
            }
        } else {
            n.Anterior.Proximo = n.Proximo;
            n.Proximo.Anterior = n.Anterior;
        }

        Tamanho--;
    }

    public NoLista<T> AtRank(int r) {
        if (r < 0 || r >= Tamanho) {
            throw new IndexOutOfRangeException("Colocação incorreta.");
        }

        NoLista<T> current = Primeiro;
        for (int i = 0; i < r; i++) {
            current = current.Proximo;
        }

        return current;
    }

    public int RankOf(NoLista<T> n) {
        int rank = 0;
        NoLista<T> current = Primeiro;
        while (current != n) {
            if (current == null) {
                throw new InvalidOperationException("O nó especificado não pertence à sequência.");
            }

            current = current.Proximo;
            rank++;
        }

        return rank;
    }
}
