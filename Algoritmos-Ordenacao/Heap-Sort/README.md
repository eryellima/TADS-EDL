# 📌 Heap Sort
O Heap Sort é um algoritmo de ordenação baseado na estrutura de dados Heap (geralmente um Max-Heap para ordenação crescente). Ele organiza os elementos em forma de árvore binária completa e garante que o maior elemento esteja semre na raiz, permitindo removê-lo e colocá-lo na posição correta.

## 🧩 Ideia básica
1. Construir um Max-Heap  partir do array.
2. Trocar o elemento da raiz (maior valor) com o último elemento da área não ordenada.
3. Reduzir o tamanho do heap (ignorando a parte já ordenada) e aplicar heapify para restaurar a propriedade do heap.
4. Repetir até todos os elementos estarem ordenados.

## 📊 Estrutura visual
~~~yaml
Passo 1 – Construir Max-Heap:
         10
       /    \
      5      3
     / \
    4   1
Array: [10, 5, 3, 4, 1]

Passo 2 – Troca raiz com último:
Array: [1, 5, 3, 4, 10]
Heapify (ignora 10): [5, 4, 3, 1, 10]

Passo 3 – Troca raiz com penúltimo:
Array: [1, 4, 3, 5, 10]
Heapify (ignora 5 e 10): [4, 1, 3, 5, 10]

Passo 4 – Continua até ordenar:
Resultado final: [1, 3, 4, 5, 10]
~~~

## ⚙️ Complexidade média
- Tempo:
    - Melhor caso: O(n log n)
    - Médio caso: O(n log n)
    - Pior caso: O(n log n)

- Espaço: O(1) (ordenamento in-place)

## 👍 Vantagens
- Complexidade O(n log n) garantida, indepedente da entrada.
- Não precisa de memória extra significativa (in-place).
- Mais estável que algoritmos O(n²) como Bubble, Select e Insert.

## 👎 Desvantagens
- Pode não ser tão estável caso tenha elementos iguais.
- Geralmente mais lento que Quick Sort na prática por causa das operações de heapify.
- Implementação mais complexa que algoritmos básicos de ordenação.