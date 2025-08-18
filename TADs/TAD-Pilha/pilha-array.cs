public class PilhaArray<T>{
    private T[] elementos;
    private int topo;
    private int capacidade;

    public PilhaArray(int tamanho){
        capacidade = tamanho;
        elementos = new T[capacidade];
        topo = -1;
    }


    public bool IsEmpty(){
        return topo == -1;
    }


    public bool IsFull(){
        return topo == capacidade - 1;
    }


    public void Push(T item){
        if(IsFull()){
            throw new InvalidOperationException("Pilha Cheia!");
        }

        elementos[++topo] = item;
    }


    public T Pop(){
        if(IsEmpty()){
            throw new InvalidOperationException("Pilha vazia!");
        }

        return elementos[topo--];
    }


    public T Peek(){
        if(IsEmpty()){
            throw new InvalidOperationException("Pilha vazia!");
        }

        return elementos[topo];
    }
}