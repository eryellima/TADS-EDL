class QuickSortAlgorithm{
    static void QuickSort(int[] array, int inicio, int fim){
        if(inicio < fim){
            int posicaoPivo = Particionar(array, inicio, fim);

            QuickSort(array, inicio, posicaoPivo - 1);
            QuickSort(array, posicaoPivo + 1, fim);
        }
    }

    static int Particionar(int[] array, int inicio, int fim){
        int pivo = array[fim];
        int i = inicio - 1;

        for(int j = inicio; j < fim; j++){
            if(array[j] <= pivo){
                i++;
                Trocar(array, i, j);
            }
        }

        Trocar(array, i + 1, fim);

        return i + 1;
    }


    static void Trocar(int[] array, int a, int b){
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }


    static void Main(string[] args){
        int[] vetor = {10, 80, 30, 90, 40, 50, 70};

        Console.WriteLine("Vetor original: " + string.Join(", ", vetor));

        QuickSort(vetor, 0, vetor.Length - 1);

        Console.WriteLine("Vetor ordenado com Quick Sort: " + string.Join(", ", vetor));
    }
}