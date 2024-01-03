private class FilaComPilhas{
    private PilhaArray P1, P2;

    public FilaComPilha(){
        P1 = new PilhaArray(0, 1);
        P2 = new PilhaArray(0, 2);
    }


    // Adiciona um elemento a fila
    /*
        a pilha pilha P2 é usada como uma "pilha auxiliar temporária." Quando é necessaário realizar o enqueue, todos os elementos de P1 são movidos para o P2, o novo elemento é adicionado em P1, e depois todos os elementos são movidos de volta para P1
    */
    public void enqueue(object o){
        // Movimenta todos os elementos de P1 para P2
        while(!P1.IsEmpty()){
            P2.Push(P1.Pop());
        }


        // Adiciona o novo elemento em P1
        P1.Push(o);

        // Move todos os elementos de P2 de volta para P1
        while(!P2.IsEmpty()){
            P1.Push(P2.Pop());
        }
    }


    // Remove e retorna o eleemnto mais antigo da fila
    public object dequeue(){
        // verificar se a fial ta vazia
        if(P1.IsEmpty()){
            Console.WriteLine("Fila vazia.");
            return null;
        }

        // Retorna o elemento do topo de P1
        return P1.Pop();
    }


    // Método para mostrar os elementos da fila
    public void mostra(){
        P1.mostra();
    }
}


public class PilhaArray{
    private object[] array;
    private int top;

 
    public PilhaArray(int capacity, int number){
        array = new object[capacity];
        top = -1;
    }

 
    public void Push(object item){
        array[++top] = item;
    }


    public object Pop(){
        if(top == -1){
            Console.WriteLine("Pilha vazia.");
            return null;
        }

        return array[top--];
    }


    public boll IsEmpty(){
        return top == -1;
    }


    public void mostra(){
        for(int i = 0; i <= top; i++){
            Console.Write(array[i]+ " ");
        }

        Console.WriteLine();
    }
}