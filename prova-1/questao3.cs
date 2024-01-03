public class PilhaArray{
    private int[] array;
    private int top;
    private int capacity;


    public PilhaArray(int initialCapacity){
        array = new int[initialCapacity];
        top = -1;
        capacity = initialCapacity;
    }


    // Método para empilhar um elemento
    /*
        verifica se a pilha ta cheia antes ded adicionar um novo elemento. se estiver cheia ele dobra o tamanho do array antes de inseriri o novo elemento.
    */
    public void Push(int num){
        // verifica se a pilha está cheia
        if(top == capacity - 1){
            // Dobra o tamanho do array
            int newCapcity = 2 * capacity;
            int[] newArray = new int[newCapcity];

            // Copia os elementos do array para um novo array
            for(int i =0; i < capacity; i++){
                newArray[i] array[i];
            }

            // Atualiza a capacidade e o array
            capacity = newCapcity;
            array = newArray;
        }

        // Adiciona o novo elemnto a pilha
        array[++top] = num;
    }


    public void Mostra(){
        for(int i = 0; i <= top; i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}


class Program{
    static void Main(){
        PilhaArray pilha = new PilhaArray(5);

        // Adicionar elementos á pilha
        for(int i = 1; i<= 10; i++){
            pilha.Push(i);
            pilha.Mostra();
        }
    }
}