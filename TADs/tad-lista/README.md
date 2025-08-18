# 📌 TAD Lista
Uma Lista é uma estrutura de dados linear composta por nós ligados, onde cada nó armazena um avlor e uma referência para o próximo nó (em listas simples) ou também para o nó anterior (em listas duplas).

## 🧩 Ideia básica
1. Cada nó contém valor + ponteiro(s).
2. O primeiro nó é chamado de cabeça(head) da lista.
3. Elementos podem ser inseridos ou removidos em qualquer posição.
4. Pode ser implementada como:
- Lista Encadeada: cada nó aponta apenas para o próximo.
- Lista Duplamente encadeada: cada nó aponta para o próximo e o anterior.
- Lista Circular: o último nó aponta de volta para o primeiro.

## 🔄 Operações principais
- Insert
- InsertLast
- Remove
- Get
- Replace
- Size
- IsEmpty

## 📊 Estrutura visual
Exemplo de lista encadeada:
~~~yaml
Head → [10] → [15] → [30] → null
~~~

Exemplo de lista duplamente encadeada:
~~~yaml
null ← [10] ↔ [15] ↔ [30] → null
~~~

- Cada nó armazena o vaor e referência para naveagr na lista.

## ⚙️ Complexidade média
Acesso (Get) O(n)
- InertFirst: O(1)
- InsertLast: O(n) - O(1) se tiver tail
- Remove: O(n) O(n)
- Tamanho: O(1) se armazenado, O(n) se não

## 👍 Vantagens
- Flexível em tamanho, cresce e diminui dinamicamente.
- Inserções e remoções são rápidas em qualquer posição se a referência ao nó for conhecida.
- Não há desperdício de memória entre elementos.
- Base para outras estruturas como pilhas, filas e listas circulares.

## 👎 Desvantagens
- Acesso direto é lento (não há índice como em vetor).
- Mais uso de memória por nó devido a ponteiros.
- Estrutura mais complexa de implementar do que um array simples.
