# 📌 Árvore Binária
Uma árvore binária é uma estrutura de dados hierárquica onde cada nó pode ter no máximo dois filhos: esquerda e direito.
Ela é usada em várias aplicações como buscas rápidas, hierarquias, expressões matemáticas e é base para árvores mais avançadas (AVL, Rubro-Negra, Heap, etc).

## 🧩 Ideia básica
1. Cada Nó da árvore armazena um valor.
2. Cada Nó tem até 2 filhos
- esquerdo
- direito
3. o Nó mais alto é chamado de raiz.
4. Nós sem filhos são chamados de folha.
5. A árvore pode ser completa, cheia balanceada ou degenerada dependendo da forma de preenchimento.

## 🌳 Tipos de Travessia
Formas de visitar os Nós da árvore:
- Pré-Ordem (Root -> Esquerda -> Direita)
- Em-Ordem (Esquerda -> Root -> Direita)
    - usado em Árvore Binária de Busca (BST) para dar saída ordenada

- Pós-Ordem (Esquerda -> Direita -> Raiz)

Exemplo com árvore:
~~~yaml
       10
      /  \
     5    15
    / \     \
   2   7     20
~~~

- Pré-Ordem → [10, 5, 2, 7, 15, 20]
- Em-Ordem → [2, 5, 7, 10, 15, 20]
- Pós-Ordem → [2, 7, 5, 20, 15, 10]

## 🔄 Operações principais
- Inserção: adiciona m nó em uma posição disponível seguindo regras da árvore
    - Exemplo: BST -> menores à esquerda, maiores à direita.

- Busca: percorrer a árvore para encontrar um valor.
- Remoção:
    - Nó folha: remove diretamente.
    - Nó com 1 filho: promove o filho.
    - Nó com 2 filho: substitui pelo sucessor (menor da subárvore direita) ou pelo antecessor (maior da subárvore esquerda).

- Travessias: visitar todos os nós na ordem desejada.

## 📊 Estrutura visual
Exemplo de Árvore Binária de Busca (BST):
~~~yaml
       8
      / \
     3   10
    / \    \
   1   6    14
      / \   /
     4   7 13
~~~

## ⚙️ Complexidade média
- Inserção: O(log n)
- Busca: O(log n)
- Remoção: O(log n)
- Travessia: O(n)
- Pior caso (árvore degenerada): O(n)

## 👍 Vantagens
- Estrutura hierárquica natural e intuitiva.
- Suporta buscas, inserções e remoções rápidas em média.
- Base para algoritmos avançados (AVL, Rubro-Negra, B-Trees).
- Permite percorrer os dados em várias ordens diferentes.

## 👎 Desvantagens
- Se desbalanceada, pode degenerar em uma lista encadeada (O(n) para operações).
- Implementação mais complexa do que arrays ou listas.
- Maior consumo de memória (ponteiros adicionais para filhos).
