# 📌 TAD Pilha Rubro-Negra
A Pilha Rubro-Negra é uma estrutura de dados LIFO (Last In, First Out) que mantém duas pilhas distintas dentro de um único array:
- Pilha Vermelha
- Pilha Preta
Essa abordagem permite que duas pilhas cresçam simultaneamente de lados opostos no mesmo array, economizando espaço e evitando desperdício de memória.

## 🧩 Ideia básica
1. O array armazena elementos de ambas as pilhas.
2. A Pilha Vermelha cresce da esquerda para a direita (do índice 0 em diante).
3. A Pilha Preta cresce da direita para a esquerda (do último índice para trás).
4. Se as duas pilhas se encontrarem, o array é redimensionado automaticamente, dobrando sua capacidade.
5. Cada pilha mantém seu topo independente (t_Vermelha e t_Preta) para controlar operações.

## 🔄 Operações principais
- Inserção
    - Push_Vermelha(T item) → adiciona um elemento no topo da pilha vermelha.
    - Push_Preta(T item) → adiciona um elemento no topo da pilha preta.

- Remoção
    - Pop_Vermelha() → remove e retorna o elemento do topo da pilha vermelha.
    - Pop_Preta() → remove e retorna o elemento do topo da pilha preta.

- Consulta
    - Top_Vermelha() → retorna o elemento do topo da pilha vermelha sem remover.
    - Top_Preta() → retorna o elemento do topo da pilha preta sem remover.

- Tamanho:
    - Size_Vermelha() → retorna o número de elementos na pilha vermelha.
    - Size_Preta() → retorna o número de elementos na pilha preta.

## 📊 Estrutura visual
Exemplo do estado do array com elementos nas duas pilhas:

~~~yaml
Índice: 0    1    2    3    4    5    6    7
Array: [10, 20, 30, _, _, _, 50, 40]
Topo Vermelha → 30
Topo Preta   → 50
~~~

- Pilha Vermelha: cresce da esquerda → topo em 30
- Pilha Preta: cresce da direita → topo em 50
- _ → espaço vazio disponível

## ⚙️ Complexidade média
- Push: O(1) amortizado (com redimensionamento)
- Pop: O(1)
- Top / Peek: O(1)
- Size: O(1)
- Redimensionar: O(n) (quando necessário)

## 👍 Vantagens
- Duas pilhas compartilhando um único array, economizando espaço.
- Operações de inserção, remoção e acesso são rápidas (O(1)) na média.
- Redimensionamento automático evita estouro de capacidade.
- Útil para algoritmos que precisam duas pilhas independentes em um mesmo espaço.

## 👎 Desvantagens
- Mais complexo de implementar que uma pilha simples.
- Redimensionamento envolve cópia de todos os elementos, custando O(n).
- Difícil de visualizar para grandes arrays, pois há duas pilhas crescendo de lados opostos.
- Não é uma estrutura padrão de bibliotecas, então exige implementação própria.
