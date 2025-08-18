# 📌 TAD Pilha
Uma Pilha é uma estrutura de dados linear que segue a política LIFO (Last In, First Out), ou seja, o último elemento inserido é o primeiro a ser removido.

## 🧩 Ideia básica
1. Inserir elementos sempre no topo da pilha.
2. Remover elementos sempre do topo da pilha.
3. Acesso somente ao último elemento inserido (não é possível acessar diretamente elementos intermediários sem removê-los).

## 🔄 Operações principais
- Push(n): insere o elemento `n` no topo da pilha.
- Pop(): remove o elemnto do topo da pilha.
- Peek() ou Top(): Consulta o elemento do topo sem removê-lo.
- isEmpty(): verifica se a pilha está vazia.
- isFull(): verifica se a pilha está cheia (caso seja implementada com tamanho fixo).

## 📊 Estrutura visual
~~~yaml
Topo -> [50]
        [40]
        [30]
        [20]
Base -> [10]
~~~

Após `pop()`:
~~~yaml
Topo -> [40]
        [30]
        [20]
Base -> [10]
~~~

## ⚙️ Complexidade média
- Push: O(1)
- Pop: O(1)
- Peek: O(1)

## 👍 Vantagens
- Estrutura simples e eficiente.
- Operações muito rápidas (tempo constante).
- Útil em problemas práticos como:
    - Desfazer/Refazer em editores (CTRL+Z).
    - Avaliação de expressões mateáticas (notação pós-fixa).
    - Chamadas de funções (stack de execução).

## 👎 Desvantagens
- Acesso restrito (apenas o topo pode ser acessado).
- Não permite busca direta em elementos intermediários.
- Se implementada com array de tamanho fixo, pode haver desperdício ou falta de espaço.