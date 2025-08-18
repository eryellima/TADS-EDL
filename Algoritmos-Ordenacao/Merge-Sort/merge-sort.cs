class MergeSortAlgorithm{
    public static void MergeSort(int[] array, int esquerda, int direita){
        if(esquerda < direita){
            int meio = (esquerda + direita) / 2;        // encontra o ponto do meio

            MergeSort(array, esquerda, meio);           //ordena a primeira metade
            MergeSort(array, meio + 1, direita);        // ordena a segunda metade

            Merge(array, esquerda, meio, direita);      // mescla as duas metades ordenadas
        }
    }


    public static void Merge(int[] array, int esquerda, int meio, int direita){
        // Tamanho dos subarrays
        int n1 = meio - esquerda + 1;
        int n2 = direita - meio;

        int[] esquerdaArray = new int[n1];
        int[] direitaArray = new int[n2];

        // Copiando dados para os arrays
        for(int i = 0; i < n1; i++){
            esquerdaArray[i] = array[esquerda + i];
        }

        for(int j = 0; j < n2; j++){
            direitaArray[j] = array[meio + 1 + j];
        }

        int iEsq = 0;
        int iDir = 0;
        int k = esquerda;

        // Mescla os arrays de volta no array principal
        while(iEsq < n1 && iDir < n2){
            if(esquerdaArray[iEsq] <= direitaArray[iDir]){
                array[k] = esquerdaArray[iEsq];
                iEsq++;
            } else{
                array[k] = direitaArray[iDir];
                iDir++;
            }

            k++;
        }

        // Copiando os elementos restantes de esquerdaArray
        while(iEsq < n1){
            array[k] = esquerdaArray[iEsq];
            iEsq++;
            k++;
        }

        // Copiando os elementos restantes de direitaArray
        while(iDir < n2){
            array[k] = direitaArray[iDir];
            iDir++;
            k++;
        }
    }


    public static void Main(){
        int[] arr = {38, 27, 42, 3, 9, 82, 10};

        Console.WriteLine("Antes: " + string.Join(", ", arr));

        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine("Depois: " + string.Join(", ", arr));
    }
}