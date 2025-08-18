class HeapSortAlgorithm{
    public static void HeapSort(int[] array){
        int n = array.Length;

        for(int i = n / 2 - 1; i >= 0; i--){
            UpHeap(array, n, i);
        }

        for(int i = n - 1; i > 0; i--){
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            UpHeap(array, i, 0);
        }
    }


    private static void UpHeap(int[] array, int tamanho, int raiz){
        int maior = raiz;       // inicializa o amior como o raiz
        int esquerda = 2 * raiz + 1;
        int direita = 2* raiz + 2;

        // Se o filho da esquerda for maior que a raiz
        if(esquerda < tamanho && array[esquerda] > array[maior]){
            maior = esquerda;
        }

        // Se o filho da direita for maior que o "maior" atual
        if(direita < tamanho && array[direita] > array[maior]){
            maior = direita;
        }

        // Se o maior não for a raiz, troca e continua o ajute no heap
        if(maior != raiz){
            int temp = array[raiz];
            array[raiz] = array[maior];
            array[maior] = temp;

            UpHeap(array, tamanho, maior);
        }
    }


    public static void Main(){
        int[] arr = {4, 10, 3, 5, 1, 2, 7};

        Console.WriteLine("Antes: " + string.Join(", ", arr));

        HeapSort(arr);

        Console.WriteLine("Depois: " + string.Join(", ", arr));
    }
}