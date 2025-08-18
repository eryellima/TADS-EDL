# 📌 TAD Fila de Prioridade
Uma Fila de Prioridade é uma estutura de dados semelhante a uma fila, mas onde cada elemento possui ma prioriadde associada.
Na Fila de Prioridade, o elemento com maior prioridade é removido primeiro, independentemente da ordem de inserção.

## 🧩 Ideia básica
1. Cada elemento armaena: valor + prioridade.
2. Inserções podem ocorrer em qualquer ordem.
3. Remoções sempre retornam o elemento com maior prioridade.
4. Elementos com mesma prioridade podem seguir orde de chegada (FIFO) ou outa regra definida.

## 🔄 Operações principais
- Insert(valor, prioridade): adiciona um elemento com determinada prioridade.
- Dequeue(): remove e retorna o elemento de aior prioridade.
- Peek(): consulta o elemento de maior prioridade sem remover.
- isEmpty(): verifica se a fila está vazia.
- Size(): retorna o número de elemetnos.

## 📊 Estrutura visual
Exemplo de fila de prioridade (maior prioridade à esquerda):
~~~yaml
[Valor: 20, Prioridade: 5] → [Valor: 30, Prioridade: 3] → [Valor: 10, Prioridade: 2]
~~~
## ⚙️ Complexidade média
- Insert: O(n)
- Dequeue: O(1)
- Peek: O(1)

## 👍 Vantagens
- Permite processar elementos por prioridade, ideal para escalonamento de tarefas, sistemas de impressão, algoritmos de grafos.
- Flexível quanto a regras de prioridade.

## 👎 Desvantagens
- Implementação mais complexa que uma fila comum.
- Inserção pode ser custos se usada lista ordenada (O(n)).
- A ordem de chegada nem sempre é preservada para elementos com mesma prioridade.
