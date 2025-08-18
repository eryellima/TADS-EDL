# 📌 Merge Sort
O Merge Sort é um algoritmo de ordenação baseado na estratégia Dividr para Conquistar (_Divide and Conquer_). Ele divide o array em metades, ordena cada metade recursivametne e depois mescla (merge) as duas metades ordenadas em um úbico array final.

## 🧩 Ideia básica
1. Dividir o array em duas metades (até que cada subarray tenha apenas um elemento).
2. Ordenar cada metade recursivametne.
3. Mesclar as duas metades ordenadas em um array único e ordenado.

## 📊 Estrutura visual
~~~yaml
Exemplo com:
[38, 27, 43, 3, 9, 82, 10]

Divisão:
[38, 27, 43, 3]   [9, 82, 10]
[38, 27] [43, 3]   [9, 82] [10]
[38] [27] [43] [3]   [9] [82] [10]

Mesclando:
[27, 38] [3, 43]   [9, 82] [10]
[3, 27, 38, 43]   [9, 10, 82]

Final:
[3, 9, 10, 27, 38, 43, 82]
~~~

## ⚙️ Complexidade média
- Tempo:
    - Melhor caso: O(n log n)
    - Médio caso: O(n log n)
    - Pior caso: O(n log n)

- Espaço: O(n) (precisa de arrays temporários para mesclar).

## 👍 Vantagens
- Complexidade O(n log n) garantida.
- Estável (mantém a ordem relatia de elementos iguais).
- Funciona bem para listas grandes.

## 👎 Desvantagens
- Requer memória extra porporcional ao tamanho da entrada (O(n)).
- Implementação recursiva pode ter sobrecarga de chamadas de função.
- Pode ser mais lento que Quick Sort na prática devido ao uso de arrays auxiliares.
