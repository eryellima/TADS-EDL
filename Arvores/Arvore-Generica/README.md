# 📌 Árvore Genérica
Uma árvore genérica é uma estrutura hierárquica onde cada nó pode ter zero ou mais filhos (diferente da árvore binária que limita a dois).
Ela é muita utilizada para representar hierarquias complexas como pastas em sistemas operacionais, árvores de sintaxe em compiladores, organogramas, XML/JSON, etc.

## 🧩 Ideia básica
1. Cada nó contém um valor e uma lista de filhos.
2. Não há limite fico para o número de filhos.
3. A raiz é o nó principal.
4. Cada nó pode ter subárvore independentes.
5. Usada quando a relação hierárquica não se encaixa bem em estruturas binárias.

## 🌳 Tipos de Travessia
- Pré-Ordem: visita o nó antes dos filhos.
- Pós-Ordem: visita todos os nós antes do nó.

Exemplo de árvore genérica:
~~~yaml
        A
      / | \
     B  C  D
       / \
      E   F
~~~

- Pré-Ordem: [A, B, C, E, F, D]
- Pós-Ordem: [B, E, F, C, D, A]

## 🔄 Operações principais
- Inserção: adiciona um nó como filho de um nó existente.
- Busca: Percorre a árvore para econtrar um valor.
- Remoção: remove um nó.
- Travessia: Visita os nós em diferentes ordens.

## 📊 Estrutura visual
Representação de uma árvore genérica de diretórios:
~~~yaml
Raiz
 ├── Pasta1
 │    ├── Arquivo1
 │    └── Arquivo2
 ├── Pasta2
 │    └── Arquivo3
 └── Pasta3
      ├── SubPasta
      │    └── Arquivo4
      └── Arquivo5
~~~

## ⚙️ Complexidade média
- Inserção: O(1) - quando já se conhece o pai.
- Busca: O(n) - pode ser necessário percorrer todos os nós.
- Remoção: O(n) - dependendo de reestruturação.
- Travessia: O(n).

## 👍 Vantagens
- Flexível (qualquer número de filhos por nó).
- Modela hierarquias reais de forma natuaral.
- Mais expressiva que a árvore binária.

## 👎 Desvantagens
- Operações de busca são menos eficiente que em árvores binárias balanceadas.
- Estrutura mais complexa para percorrer e gerenciar.
- Consome mais memória devido à lista de filhos em cada nó.