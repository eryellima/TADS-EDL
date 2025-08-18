# 📌 Bucket Sort
O Bucket SOrt é um algoritmo de odenção por distribuição que divide os elementos em "baldes" (ou buckets) e depois ordena cada balde individualmente, combinando-os ao final.
É mais eficiente quando os dados são uniformemente distribuídos dentro de um intervalo conhecido.

## 🧩 Ideia básica
1. Criar um número fixo de buckets (listas ou vetores) para representar intervalos de valores.
2. Distribuir os elementos do array original dentro desses buckets com base no seu valor.
3. Ordenar cada Bucket (geralmente usando outro algoritmo, como Insertion Sort).
4. Concatenar todos os buckets em ordem para obter o array final ordenado.

## 📊 Estrutura visual
Imagine que temos o array:
[0.42, 0.32, 0.23, 0.52, 0.25, 0.47, 0.51]
~~~yaml
Passo 1 – Buckets (antes de distribuir)
Bucket 0: []
Bucket 1: []
Bucket 2: []
Bucket 3: []
Bucket 4: []

Passo 2 – Distribuição
Bucket 2: [0.23, 0.25]
Bucket 3: [0.32]
Bucket 4: [0.42, 0.47]
Bucket 5: [0.51, 0.52]

Passo 3 – Ordenar cada bucket
Bucket 2: [0.23, 0.25]
Bucket 3: [0.32]
Bucket 4: [0.42, 0.47]
Bucket 5: [0.51, 0.52]

Passo 4 – Concatenar
[0.23, 0.25, 0.32, 0.42, 0.47, 0.51, 0.52]
~~~

## ⚙️ Complexidade média
- Tempo:
    - Melhor caso: O(n + k) (k = número de buckets).
    - Pior caso: O(n²) (se todos caírem no mesmo bucket e for usado Insertion Sort interno).
    - Caso médio: O(n + k), assumindo distribui~çao uniforme.
    
- Espaço: O(n + k) (necessário espaço extra para os buckets)

## 👍 Vantagens
- Muito eficiente para valores uniformemente distribuídos.
- Pode ser mais rápido que algoritmos baseados em compara~çao (como Quick Sort) em casos específicos.
- Fácil de paralelizar (cada bucket pode ser ordenado separadamente em threads).

## 👎 Desvantagens
- Desempenho cai drasticamente se os dados não forem uniformes.
- Precisa de espaço extra proporcional ao tamanho dos dados.
- Escolha do número de buckets influencia muito o resultado.
- Geralmente mais útil para dados numéricos contínuos (ou que podem ser normalizados).
