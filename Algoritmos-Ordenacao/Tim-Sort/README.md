# 📌 Tim Sort
O Tim Sort é um algoritmo de ordenação híbrido, usado em linguagens como Python (sort()) e Java (Arrays.sort() para objetos). Ele combina o Merge Sort e o Insertion Sort, aproveitando padrões já parcialmente ordenados no array.

## 🧩 Ideia básica
1. Dividir o array em blocos menores (runs):
- O array é dividido em subarrays de tamanho fixo (chamados runs), geralmente de 32 ou 64 elementos.
2. Ordenar cada run com Insertion Sort:
- Como o Insertion Sort é muito eficiente em listas pequenas e quase ordenadas, ele é usado nessa etapa.
3. Mesclar os runs com Merge Sort:
- Depois de cada bloco ordenada, eles são mesclados de forma parecida com o Merge Sort, até formar o array final ordenado.
4. Aproveitar ordenação naturais:
- Se partes do array já estiverem crescentes ou decrescentes, o Tim Sort detecta e usa isso para reduzir o trabalho.

## 📊 Estrutura visual
~~~yaml
Exemplo com um array e run size = 4:
[5, 21, 7, 23, 19, 10, 1, 3]

Passo 1 - Divisão em runs:
[5, 21, 7, 23] | [19, 10, 1, 3]

Passo 2 - Ordenação por Insertion Sort:
[5, 7, 21, 23] | [1, 3, 10, 19]

Passo 3 - Mescla (Merge):
[1, 3, 5, 7, 10, 19, 21, 23]
~~~

## ⚙️ Complexidade média
- Tempo:
    - Melhor caso: O(n) → quando o array já está ordenado ou quase ordenado.
    - Médio caso: O(n log n)
    - Pior caso: O(n log n)

- Espaço extra: O(n) (para mesclagem).

## 👍 Vantagens
- Muito eficiente em arrays parcialmente ordenados.
- Usado em implementações reais (Python e Java).
- Estável (mantém a ordem de elementos iguais).
- Combina vantagens do Insertion Sort (para pequenas partes) e do Merge Sort (para grandes partes).

## 👎 Desvantagens
- Mais complexo de implementar que outros algoritmos de ordenação.
- Precisa de memória extra (O(n)), diferente do Quick Sort in-place.
- Pouco usado em contextos acadêmicos (mais em aplicações práticas).