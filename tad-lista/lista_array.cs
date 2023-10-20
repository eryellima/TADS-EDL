public class TADListaArray<T> {
    private T[] array;
    private int size;

    public TADListaArray(int capacity) {
        array = new T[capacity];
        size = 0;
    }

    public int Size() {
        return size;
    }

    public bool IsEmpty() {
        return size == 0;
    }

    public bool IsFirst(int n) {
        return n == 0;
    }

    public bool IsLast(int n) {
        return n == size - 1;
    }

    public T First() {
        if (IsEmpty()) {
            throw new InvalidOperationException("A lista está vazia.");
        }

        return array[0];
    }

    public T Last() {
        if (IsEmpty()) {
            throw new InvalidOperationException("A lista está vazia.");
        }

        return array[size - 1];
    }

    public T Before(int n) {
        if (n <= 0 || n >= size)
        {
            throw new IndexOutOfRangeException("Posição incorreta.");
        }

        return array[n - 1];
    }

    public T After(int n) {
        if (n < 0 || n >= size - 1) {
            throw new IndexOutOfRangeException("Posição incorreta.");
        }

        return array[n + 1];
    }

    public void ReplaceElement(int n, T element) {
        if (n < 0 || n >= size) {
            throw new IndexOutOfRangeException("Posição incorreta.");
        }

        array[n] = element;
    }

    public void InsertBefore(int n, T element) {
        if (n < 0 || n > size) {
            throw new IndexOutOfRangeException("Posição incorreta.");
        }

        if (size == array.Length) {
            // Se o array estiver cheio, redimensiona
            ResizeArray();
        }

        for (int i = size; i > n; i--) {
            array[i] = array[i - 1];
        }

        array[n] = element;
        size++;
    }

    public void InsertAfter(int n, T element) {
        if (n < 0 || n >= size) {
            throw new IndexOutOfRangeException("Posição incorreta.");
        }

        if (size == array.Length) {
            // Se o array estiver cheio, redimensiona
            ResizeArray();
        }

        for (int i = size; i > n + 1; i--) {
            array[i] = array[i - 1];
        }

        array[n + 1] = element;
        size++;
    }

    public void InsertFirst(T element) {
        InsertBefore(0, element);
    }

    public void InsertLast(T element) {
        if (size == array.Length) {
            // Se o array estiver cheio, redimensionena
            ResizeArray();
        }

        array[size] = element;
        size++;
    }

    public void Remove(int n) {
        if (n < 0 || n >= size) {
            throw new IndexOutOfRangeException("Posição incorreta.");
        }

        for (int i = n; i < size - 1; i++) {
            array[i] = array[i + 1];
        }

        size--;
    }

    private void ResizeArray() {
        int newCapacity = (array.Length == 0) ? 1 : array.Length * 2;
        T[] newArray = new T[newCapacity];

        for (int i = 0; i < size; i++) {
            newArray[i] = array[i];
        }

        array = newArray;
    }
}
