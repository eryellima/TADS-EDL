# 📌 Skip List
Uma Skip List é uma estrutura de dados probabilística que permite busca, inserção e remoção rápidas, similar às árvores balanceadas (como AVL ou Rubro-Negra), mas mais siples de implementar.
Ela utiliza múltiplos níveis de listas encadeadas para "pular" elementos e reduzir o tempo de busca.

## Métodos Genéricos
- Busca: começa do nível mais alto e vai descendo até encontrar o elemento ou confirmar que não existe.
- Inserção: insere o elemento na lista base e, com probabilidade, promove-o a níveis superiores.
- Remoção: remove o elemeto em todos os níveis em que aparece.

## 🧩 Ideia básica
1. Base: começa com uma lista encadeada simlpes, ordenada.
2. Níveis: adiciona camadas acima dela, onde cada nível "pula" alguns elementos da lista inferior.
- Cada elemento pode aparecer em vários níveis com uma probabilidade (geralmente 50%).

## 📊 Estrutura visual
Exemplo de Skip List com 4 níveis:
~~~yaml
Nível 3:   [1] --------------------------------------------------> [9]
Nível 2:   [1] ----------------------> [5] ----------------------> [9]
Nível 1:   [1] --------> [3] --------> [5] --------> [7] --------> [9]
Nível 0:   [1] -> [2] -> [3] -> [4] -> [5] -> [6] -> [7] -> [8] -> [9]
~~~
- Nível 0: contém todos os elementos.
- Níveis superiores: atuam como "atalhos" para acelerar buscas.

## ⚙️ Complexidade média
- Busca: O(log n) em média.
- Inserção: O(log n) em média.
- Remoção: O(log n) em média.
- Pior caso (raro): O(n), se a aleatoriedade não favorecer.

## 👍 Vantagens
- Mais simples de implementar que árvores balanceadas.
- Estrutura flexível e probabilística.
- Bom desempenho médio em todas as operações.
- Dinâmica: não precisa de balanceamento como AVL ou Rubro-Negra.

## 👎 Desvantagens
- O(log n) é apenas média - depende da aleatoriedade.
- Consome mais memória, pois um mesmo elemento pode aparecer em multiplos níveis.
- Mais difícil de entender visualmente do que uma simples lista encadeada.