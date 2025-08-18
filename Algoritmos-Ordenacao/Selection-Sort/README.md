# 📌 Select Sort
O Select Sort é um algoritmo de ordenação simples que encontra repetidamente o menor (ou maior) elemento do array e o coloca na posição correta, trocando com o elemento atual da iteraçã.

## 🧩 Ideia básica
1. Percorrer o array e encontrar o menor elemento.
2. Trocar esse elemento com o primeiro elemendo da lista.
3. Repetir o processo para o restante do array (ignorando o que já foi ordenado no início).
4. Continuar até que todo o array esteja ordenado.

## 📊 Estrutura visual
~~~yaml
Passo 1:
Menor elemento = 11 → troca com 64
[11, 25, 12, 22, 64]

Passo 2:
Menor elemento do restante = 12 → troca com 25
[11, 12, 25, 22, 64]

Passo 3:
Menor elemento do restante = 22 → troca com 25
[11, 12, 22, 25, 64]

Passo 4:
Menor elemento do restante = 25 → já está no lugar
[11, 12, 22, 25, 64]
~~~

## ⚙️ Complexidade média
- Tempo:
    - Melhor caso: O(n²)
    - Pior caso: O(n²)
    - Caso médio: O(n²)
    - (Independente da ordem inicial, sempre percorre todo o array.)
    
- Espaço: O(1) (ordenamento in-place).

## 👍 Vantagens
- Implementação simples.
- Não depende da ordem inicial dos dados.
- Realiza o mínimo possível de trocas (no máximo `n - 1`).

## 👎 Desvantagens
- Ineficiente para listas grandes (O(n²)).
- Sempre percorre todo o array, mesmo se já estiver quase ordenado.
- Geralmente mais lento que Insertion SOrt para entradas pequenas parcialmente orenadas.
