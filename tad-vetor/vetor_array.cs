using System;

public class VetorArray<T> {
    // Array para armazenar os elementos
    private T[] array;
    // Tamanho atual do vetor
    private int n;

    public VetorArray(int capacity) {
        array = new T[capacity];
        n = 0;
    }

    public T ElemAtRank(int r) {
        if (r < 0 || r >= n) {
            throw new IndexOutOfRangeException("Colocação incorreta.");
        }

        return array[r];
    }

    public T ReplaceAtRank(int r, T element) {
        if (r < 0 || r >= n) {
            throw new IndexOutOfRangeException("Colocação incorreta.");
        }

        T oldElement = array[r];
        array[r] = element;
        return oldElement;
    }

    public void InsertAtRank(int r, T element) {
        if (r < 0 || r > n) {
            throw new IndexOutOfRangeException("Colocação incorreta.");
        }

        if (n == array.Length) {
            // Se o array estiver cheio, redimensione-o
            ResizeArray();
        }

        // Desloqueia os elementos à direita para abrir espaço para o novo elemento
        for (int i = n; i > r; i--) {
            array[i] = array[i - 1];
        }

        array[r] = element;
        n++;
    }

    public T RemoveAtRank(int r) {
        if (r < 0 || r >= n) {
            throw new IndexOutOfRangeException("Colocação incorreta.");
        }

        T removedElement = array[r];

        // Desloca os elementos à esquerda para preencher o espaço deixado pelo elemento removido
        for (int i = r; i < n - 1; i++) {
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

    private void ResizeArray() {
        // Redimensione o array para o dobro do tamanho atual
        int newCapacity = (array.Length == 0) ? 1 : array.Length * 2;
        T[] newArray = new T[newCapacity];

        // Copie os elementos do array antigo para o novo array
        for (int i = 0; i < n; i++) {
            newArray[i] = array[i];
        }

        array = newArray;
    }
}
