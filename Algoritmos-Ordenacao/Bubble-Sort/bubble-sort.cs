class BubbleSortAlgorithm{
    public static void BubbleSort(int[] array){
        int n = array.Length;
        bool trocou;

        for (int i = 0; i < n - 1; i++){
            trocou = false;

            for (int j = 0; j < n - i - 1; j++){
                if (array[j] > array[j + 1]){
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;

                    trocou = true;
                }
            }

            if (!trocou){
                break;
            }
        }
    }

    public static void Main(){
        int[] arr = { 5, 3, 4, 1, 2 };

        Console.WriteLine("Antes: " + string.Join(", ", arr));

        BubbleSort(arr);

        Console.WriteLine("Depois: " + string.Join(", ", arr));
    }
}