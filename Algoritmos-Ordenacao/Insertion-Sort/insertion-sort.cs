class InsertionSortAlgorithm{
    public static void InsertionSort(int[] array){
        int n = array.Length;

        for(int i = 1; i < n; i++){
            int chave = array[i];
            int j = i - 1;

            while(j >= 0 && array[j] > chave){
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1]= chave;
        }
    }


    public static void Main(){
        int[] arr = {5, 3, 4, 1, 2};

        Console.WriteLine("Antes: " + string.Join(", ", arr));

        InsertionSort(arr);

        Console.WriteLine("Depois: " + string.Join(", ", arr));
    }
}