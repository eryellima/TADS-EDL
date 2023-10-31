using System;


public class Fila {
    private object[] array;
    private int capacidade;
    private int inicio;
    private int fim;


    public Fila(int capacidadeInicial) {
        // Aumenta a capacidade em 1 para acomodar o elemento vazio que indica o fim da fila
        capacidade = capacidadeInicial + 1;
        array = new object[capacidade];
        inicio = 0;
        fim = 0;
    }


    public void Enqueue(object item) {
        // Vai redimensionar o array se a fila estiver cheia.
        if(EstaCheia()) {
            Redimensionar();
        }

        array[fim] = item;
        // Atualiza o índicedo fim considerando uma estrutura de array circular
        fim = (fim +1) % capacidade;
    }


    public object Dequeue(){
        if(EstaVazia()) {
            throw new EFilaVazia("A fila está vazia.");
        }

        // Remove o elemento do início da fila
        object item = array[inicio];
        // vai definir a posição do início como nula
        array[inicio] = null;
        // atualiza o indice do início
        inicio = (inicio + 1) % capacidade;

        // Retornao primeiro elemento
        return item;
    }


    public object First() {
        if(EstaVazia()) {
            throw new EFilaVazia("A fila está vazi.");
        }

        return array[inicio];
    }


    public int Tamanho() {
        // Calcula o tamanho da fila considerando a estrutura de array circula
        return (capacidade + fim - inicio) % capacidade;
    }


    public bool EstaVazia() {
        // Verifica se o início e o fim são iguais, para  indicar que a fila está vazia.
        return inicio == fim;
    }


    public bool EstaCheia() {
        // Verifica se o próximo índice do fim é igual ao índice do início, para poder indicar que a fila está cheia.
        return (fim + 1) % capacidade == inicio;
    }


    public void Redimensionar() {
        int novoTamanho = capacidade * 2;
        object[] novoArray = new object[novoTamanho];
        int tamanho = Tamanho();

        // Copia os elementos para o novo array
        for(int i = 0; i < tamanho; i++) {
            novoArray[i] = array[(inicio + i) % capacidade];
        }

        // atualiza o array
        array = novoArray;
        capacidade = novoTamanho;
        inicio = 0;
        
        // Atualiza o índice de início e fim
        fim = tamanho;
    }
}



// Classe personalizada que herda da classe base 'Exception'. Permite que a classe tenha todas as características e comportamentos de uma exceção
public class EFilaVazia : Exception {
    public EFilaVazia(string mensagem) : base(mensagem) {

    }
}
