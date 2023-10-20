using System;

// A classe Pilha<T> é definida como genérica, onde T é um tipo genérico que será especificado ao criar uma instância da classe.
class Pilha<T> {
    private T[] array;
    private int tamanho;
    private int t_Vermelha; // Índice para o topo da pilha vermelha
    private int t_Preta; // Índice para o topo da pilha preta


    // Construtor que cria uma instância da classe Pilha. Inicializa o array    
    public Pilha(int capacidade) {
        if (capacidade <= 0) {
            throw new ArgumentException("A capacidade deve ser maio que zero!");
        }

        array = new T[capacidade];
        tamanho = capacidade;
        t_Vermelha = -1;
        t_Preta = tamanho;
    }


    // Método para inserir elementos na pilha, verifica se há espaço disponível e remensiona o array
    public void Push_Vermelha(T item) {
        if (t_Vermelha + 1 == t_Preta) {
            Redimensionar();
        }

        t_Vermelha++;
        array[t_Vermelha] = item;
    }

    // Método para inserir elementos na pilha, verifica se há espaço disponível e remensiona o array
    public void Push_Preta(T item) {
        if (t_Preta -1 == t_Vermelha) {
            Redimensionar();
        }

        t_Preta--;
        array[t_Preta] = item;
    }


    // Método para remover elementos na pilha e lança uma exceção se a pilha estiver vazia.
    public T Pop_Vermelha() {
        if (t_Vermelha == -1) {
            throw new InvalidOperationException("A pilha está vazia!");
        }

        T item = array[t_Vermelha];
        t_Vermelha--;
        return item;
    }

    // Método para remover elementos na pilha e lança uma exceção se a pilha estiver vazia.
    public T Pop_Preta() {
        if (t_Preta == tamanho) {
            throw new InvalidOperationException("A pilha está vazia!");
        }

        T item = array[t_Preta];
        t_Preta++;
        return item;
    }


    // Método para retornar o elemento no topo da pilha sem remover e lança uma exceção se a pilha esttiver vazia.
    public T Top_Vermelha() {
        if (t_Vermelha == -1) {
            throw new InvalidOperationException("A pilha vermelha está vazia.");
        }

        return array[t_Vermelha];
    }

    // Método para retornar o elemento no topo da pilha sem remover e lança uma exceção se a pilha esttiver vazia.
    public T Top_Preta() {
        if (t_Preta == tamanho) {
            throw new InvalidOperationException("A pilha preta está vazia.");
        }

        return array[t_Preta];
    }


    // método que retornam o número de elementos nas respectivas pilhas.
    public int Size_Vermelha() {
        return t_Vermelha + 1;
    }

    // método que retornam o número de elementos nas respectivas pilhas.
    public int Size_Preta() {
        return tamanho - t_Preta;
    }


    // Método para aumentar a capacidade do array quando ambas as pilhas estão cheias.
    private void Redimensionar() {
        int nova_capacidade = tamanho *2;
        T[] novo_array = new T[nova_capacidade];
        
        for(int i = 0; i <= t_Vermelha; i++) {
            novo_array[i] = array[i];
        }

 
        int novo_t_Preta = nova_capacidade - 1;

        for(int i = tamanho -1; i >= t_Preta; i--) {
            novo_array[novo_t_Preta] = array[i];
            novo_t_Preta--;
        }

        tamanho = nova_capacidade;
        t_Preta = novo_t_Preta;
        array = novo_array;
    }
}