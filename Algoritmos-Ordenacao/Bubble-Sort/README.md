# 📌 Buble Sort
O Bubble Sort é um algoritmo de ordenação simples que compara pares de elementos adjacentes e os troca se estiverem na ordem errada, repetindo o processo até que o array esteja ordenado.
O nome vem do fato de os elementos "maiores" irem subindo para o final da lista, como bolhas na água.

## 🧩 Ideia básica
1. Percorrer o array várias vezes.
2. Em cada passagem, comparar elementos adjacentes.
3. Se estiverem na ordem errada, trocá-los.
4. Repetir até que nenhuma troca seja necessária.

## 📊 Estrutura visual
~~~yaml
Passo 1:
[3, 5, 4, 1]  (5 e 3 trocam)
[3, 4, 5, 1]  (5 e 4 trocam)
[3, 4, 1, 5]  (5 e 1 trocam)  -> maior elemento foi para o final

Passo 2:
[3, 4, 1, 5]
[3, 1, 4, 5]  (4 e 1 trocam)
[1, 3, 4, 5]  (3 e 1 trocam)

Passo 3:
Nenhuma troca -> lista ordenada
~~~

## ⚙️ Complexidade média
- Tempo:
    - Melhor caso: O(n) (se otimizado com verificação de trocas e o array já estiver ordenado).
    - Pior caso: O(n²).
    - Caso médio O(n²).

- Espaço: O(1) (ordenamento in-place).

## 👍 Vantagens
- Implementação simples e fácil de entender.
- Funciona bem com listas pequenas.
- Não requer memória extra além de ariáveis auxiliares.

## 👎 Desvantagens
- Muito lento para listas grandes.
- Número de comparações e trocas é alto.
- Pouco utilizado na prática, exceto para fins didáticos.
