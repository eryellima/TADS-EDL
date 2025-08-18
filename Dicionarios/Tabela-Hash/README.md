# 📌 Tabela Hash
Uma Tabela Hash é uma estrutura de dados que armazena elementos em pares (cahve, valor), permitindo acesso, inserção e remoção rápidos.
A ideia é usar uma fun~çao de hash que tranforma a chave em um índice da tabela, onde o valor será armazenado.

## 🧩 Ideia básica
1. Chave -> Função de Hash -> Índice
- Cada chave é processada por uma função de hash, que gera um número inteiro correspondente a uma posiãção no array da tabela.
2. Armazenamento
- O valor associado à chave é armazenado nessa posição.
3. Colisões
- Se duas chaves diferentes gerarem o mesmo índice (colisão), existem técnicas para resolver:
    - Encadeamento (Chaining): cada posição da tabela aponta para uma lista de elementos.
    - Sondagem (Probing): procurar a próxima posição livre no array (linear, quadrática, etc.).
4. Busca e Remoção
- Para buscar, basta aplicar a função de hash novamente e acessar o índice.
- Para remover, o processo é semelhante, cuidando das colisões.

## 🔄 Operações principais
- Inserção:
    - Calcular índice da chave usando a função de hash.
    - Armazenar o valor (resolvendo colisões se necessário).

- Busca:
    - Calcular índice da chave.
    - Retornar o valor armazenado naquele índice ou na lista ligada (caso de encadeamento).

- Remoção:
    - Localizar a chave.
    - Remover o par(cahve, valor, ajustando a estrutura em caso de colisão).

## 📊 Estrutura visual
Exemplo de tabela hash com encadeamento:

~~~yaml
Índice   Elementos
0   →   (15, "A") → (25, "B")
1   →   (1, "C")
2   →   (12, "D")
3   →   (3, "E") → (23, "F")
4   →   vazio
~~~

Função de hash: h(x) = x mod 5
- 15 mod 5 = 0 -> vai para o índice 0
- 25 mod 5 = 0 -> colisão, encadeado no índice 0
-  1 mod 5 = 1 -> índice 1
- 23 mod 5 = 3 -> colisão no índice 3

## ⚙️ Complexidade média
- Inserção: O(1) em média, O(n) no pior caso(muitas colisões).
- Busca: O(1) em média, O(n) no pior caso.
- Remoção: O(1) em média, O(n) no pior caso.

O desempenho depende da qualidade da funçaõ de hash e do fator de carga (número de elementos / tamanho da tabela).

## 👍 Vantagens
- Operações muito rápidas em média.
- Ideal para acesso direto a dados por chave.
- Base de muitas aplicações reais: banco de dados, caches, dicionários em linguagens de programação.

## 👎 Desvantagens
- Se a função de hash não for bem projetada, pode gerar muitas colisões e degradar o desempenho.
- Não mantém os elementos em ordem
- Pode derperdiçar memória quando a tabela é muito grande.
- Requer redimensionamento (rehashing) quando o número de elementos cresce demais.