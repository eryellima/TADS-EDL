class SelectionSortAlgorithm{
    public static void SelectionSort(int [] array){
        int n = array.Length;

        for(int i = 0; i < n - 1; i++){
            int indiceMenor = i;

            for(int j = i + 1; j < n; j++){
                if(array[j] < array[indiceMenor]){
                    indiceMenor = j;
                }
            }

            if(indiceMenor != i){
                int temp = array[i];
                array[i] = array[indiceMenor];
                array[indiceMenor] = temp;
            }
        }
    }


    public static void Main(){
        int[] arr = {64, 25, 12, 22, 11};

        Console.WriteLine("Antes: " + string.Join(", ", arr));

        SelectionSort(arr);

        Console.WriteLine("Depois: " + string.Join(", ", arr));
    }
}