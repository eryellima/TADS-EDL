# 📌 TAD Vetor
Um Vetor é uma estrutura de dados linear que armazena elementos em posições de memória. Cada elemento é acessível por um índice inteiro, permitindo acesso direto a qualquer posição.

## 🧩 Ideia básica
1. Armazena elementos de mesmo tipo em posições consecultivas de memória.
2. Permite acesso direto aos elementos através de um índice (`vetor[i]`).
3. Pode ter tamanho fixo (array estático) ou dinâmico (redimensionável).

## 🔄 Operações principais
- Insert: adiciona um elemento em uma posição específica (deslocando os demais se necessário).
- InsertLast: adiciona elemento no final do vetor.
- Remove: remove elemento de uma posição específica.
- Replace: altera o valor de um elemento existente.
- Get: retorna o valor de um elemento.
- Size: retorna o número de elementos atualmente armazenados.
- IsEmpty: verifica se o vetor está vazio.

## 📊 Estrutura visual
Exemplo de vetor com 5 posições e 3 elementos preenchidos:
~~~yaml
Índice: 0   1   2   3   4
Vetor:  10  20  30  _   _
~~~

- `_` indica posição vazia.
- Acesso direto pelo índice: `vetor[1] = 20`.

## ⚙️ Complexidade média
- Acesso (Gets/Replace): O(1).
- InsertLast: O(1) - vetor dinâmico.
- Insert: O(n).
- Remove: O(n).
- Size: O(1).

## 👍 Vantagens
- Acesso direto e rápido a qualquer elemento.
- Estrutura simples e eficiente.
- Fácil de implementar e compreender.
- Base para muitas outras estruturas de dados (pilha, filas, listas).

## 👎 Desvantagens
- Inserções e remoções em posições arbitrárias exigem deslocamento de elementos.
- Pode haver desperdício de memória se o array for grande e parcialmente preenchido.
