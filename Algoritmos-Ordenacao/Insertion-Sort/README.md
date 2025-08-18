# 📌 Insert Sort
O Insert Sort é um algoritmo de ordenação simples que contrói o array ordenado elemento por elemento, inserido cada novo elemento na posição correta dentro da parte já ordenada.

## 🧩 Ideia básica
1. Começa pelo segundo elemento do array.
2. Comparar esse elemento com os elementos anteriores da lista já ordenada.
3. Inserir o elemento na posição correta dentro da parte ordenada.
4. Repetir para todos os elementos até o final do array.

## 📊 Estrutura visual
~~~yaml
Passo 1: 5 (já está "ordenado")
[5, 3, 4, 1]

Passo 2: 3 → inserir antes de 5
[3, 5, 4, 1]

Passo 3: 4 → inserir entre 3 e 5
[3, 4, 5, 1]

Passo 4: 1 → inserir antes de 3
[1, 3, 4, 5]
~~~

## ⚙️ Complexidade média
- Tempo:
    - Melhor caso: O(n) (array já ordenado)
    - Pior caso: O(n²) (array em ordem inversa)
    - Caso médio: O(n²)

- Espaço: O(1) (ordenamento in-place)

## 👍 Vantagens
- Simples de implementar a entender.
- Muito eficiente para listas pequenas ou quase ordenadas.
- Ordena in-place, sem memória extra.
- Estável (não muda a ordem relativa de elementos iguais).

## 👎 Desvantagens
- Ineficiente para listras grandes (O(n²)).
- Não recomendado para grandes volumes de dados comparado a Quick Sort ou Merge Sort.