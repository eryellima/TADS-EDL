class TimSortAlgorithm{
    const int TAMANHO_MINIMO = 32;

    // Ordena um array usando Insertion Sort
    static void OrdenarBloco(int[] vetor, int inicio, int fim){
        int i = inicio + 1;

        while(i <= fim){
            int valor = vetor[i];
            int j = i - 1;

            while(j >= inicio && vetor[j] > valor){
                vetor[j + 1] = vetor[j];
                j--;
            }

            vetor[j + 1] = valor;
            i++;
        }
    }


    // Junta dois blocos ordenados em um só
    static void UnirBlocos(int[] vetor, int inicio, int meio, int fim){
        int tamanho1 = meio - inicio + 1;
        int tamanho2 = fim - meio;

        int[] blocoA = new int[tamanho1];
        int[] blocoB = new int[tamanho2];

        // Copiando dados para blocos temporários
        for(int x = 0; x < tamanho1; x++){
            blocoA[x] = vetor[inicio + x];
        }

        for(int y = 0; y < tamanho2; y++){
            blocoB[y] = vetor[meio + 1 + y];
        }

        int i = 0, j = 0, k = inicio;

        // Intercala até acabar um dos blocos
        while(i < tamanho1 && j < tamanho2){
            if(blocoA[i] <= blocoB[j]){
                vetor[k++] = blocoA[i++];
            } else{
                vetor[k++] = blocoB[j++];
            }
        }

        // Copia o que sobrou
        while(i < tamanho1){
            vetor[k++] = blocoA[i++];
        }

        while(j < tamanho2){
            vetor[k++] = blocoB[j++];
        }
    }


    // Algoritmo principal
    public static void ExecutarTimSort(int[] vetor){
        int n = vetor.Length;
        int inicio = 0;
        
        while(inicio < n){
            int fim = Math.Min(inicio + TAMANHO_MINIMO - 1, n - 1);
            OrdenarBloco(vetor, inicio, fim);
            inicio += TAMANHO_MINIMO;
        }

        // 2️⃣ Faz merge
        int tamanho = TAMANHO_MINIMO;
        
        while (tamanho < n){
            int esquerda = 0;

            while (esquerda < n){
                int meio = esquerda + tamanho - 1;
                
                if (meio >= n - 1){
                    break;
                }

                int direita = Math.Min(esquerda + 2 * tamanho - 1, n - 1);

                UnirBlocos(vetor, esquerda, meio, direita);

                esquerda += 2 * tamanho;
            }

            tamanho *= 2;
        }
    }


    // Teste
    static void Main(){
        int[] dados = { 42, 15, 8, 23, 4, 16, 9, 55, 1, 30 };

        Console.WriteLine("Antes da ordenação:");
        Console.WriteLine(string.Join(", ", dados));

        ExecutarTimSort(dados);

        Console.WriteLine("\nDepois da ordenação:");
        Console.WriteLine(string.Join(", ", dados));
    }
}
