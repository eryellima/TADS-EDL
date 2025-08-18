public class No<T>{
    public T Valor;
    public No<T> Proximo;
    
    public No(T valor){
        Valor = valor;
        Proximo = null;
    }
}


public class PilhaLista<T>{
    private No<T> topo;
    
    public PilhaLista(){
        topo = null;
    }


    public bool IsEmpty(){
        return topo == null;
    }


    public void Push(T item){
        No<T> novoNo = new No<T>(item);
        novoNo.Proximo = topo;
        topo = novoNo;
    }


    public T Pop(){
        if(IsEmpty()){
            throw new InvalidOperationException("Pilha vazia!");
        }

        T valor = topo.Valor;
        topo = topo.Proximo;
        return valor;
    }


    public T Peek(){
        if(IsEmpty()){
            throw new InvalidOperationException("Pilha vazia!");
        }

        return topo.Valor;
    }
}