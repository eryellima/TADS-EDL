# 📌 Quick Sort
O Quick Sort é um algoritmo de ordenação que segue a estratégia Dividir e Conquistar. Ele escolhe um elemento como pivô e particiona o array em duas partes;

## 🧩 Ideia básica
1. Escolher o pivô (pode ser o primeiro, último, aleatório ou mediana).
2. Particionar o array de forma que:
- Elementos menores ou iguais ao pivô fiquem à esquerda
- Elementos maiores que o pivô fiquem à direita.
3. Aplicar o Quick Sort recursivamente à sublista esquerda e à sublista direita.
4. Combinar os resultados (na prática, o array é ordenado "in-place", sem criar muitos arrays temporários).

## 📊 Estrutura visual
~~~yaml
Exemplo com:
{10, 80, 70, 90, 40, 50, 70}

Passo 1: Escolhe pivô 70
[10, 30, 40, 50] [70] [80, 90]

Passo 2: Ordena a parte esquerda
[10, 30, 40, 50] já está ordenada

Passo 3: Ordena a parte direita
[80, 90] já está ordenada

Resultado final:
[10, 30, 40, 50, 70, 80, 90]
~~~

## ⚙️ Complexidade média
- Tempo:
    - Melhor caso: O(n log n) - quando o o pivô divide bem o array.
    - Pior caso: O(n²) - ocorre quando o pivô é sempre o menor ou maior elemento.
    - Caso médio: O(n log n)

## 👍 Vantagens
- Muito rápido na prática, melhor que Merge Sort para arrays pequenos a médios.
- Ordenação in-place.
- Fácil de adaptar para diferentes estratégias de escolha de pivô.

## 👎 Desvantagens
- Pior caso pode ser O(n²) se não escolher bem o pivô.
- Implementação recursiva pode estourar a pilha se a entrada for muito grande e mal balanceada.