# 📌 TAD Fila
Uma Fila é uma estrutura de dados linear que segue a política FIFO (First In, First Out), ou seja, o primeiro elemento a entrar é o primeiro a sair. É equivalente a uma fila de pessoas: quem chega primeiro é aatendido primeiro.

## 🧩 Ideia básica
1. Elementos são adicionados no final da fila (enqueue).
2. Elementos são removidos do início da fila (dequeue).
3. O primeiro elemento inserido é smpre o primeiro a ser removido.
4. Pode ser implementada usando arrays, listas encadeadas ou estruturas circulares.

## 🔄 Operações principais
- Enqueue(n): insere o elemento `n` no final da fila.
- Dequeue(): remove o elemento do início da fila.
- Peek(): consulta o elemento do início sem removê-lo.
- isEmpty(): verifica se a fila está vazia.
- Size(): retorna o número de elementos na fila.


## 📊 Estrutura visual
Exemplo de fila com 3 elementos:
~~~yaml
Frente -> [10] -> [20] -> [30] <- Final
~~~

Após Dequeue():
~~~yaml
Frente -> [20] -> [30] <- Final
~~~

## ⚙️ Complexidade média
- Enqueue: O(1) - array circular
- Dequeue: O(1)
- Front: O(1)
- Size: O(1)

## 👍 Vantagens
- Estrutur simples e intuitiva.
- Permite processamento em ordem de chegada, ideal para sistemas de fila de atendimento, buffers, e gerenciamento de tarefas.
- Implementações circulares evitam desperdício de memória.
- Operações rápidas (O(1)) em média.

## 👎 Desvantagens
- Acesso restrito (apenas no início e final).
- Se implementada com array estático, pode haver overflow ou necessidade de redimensionamento.
- Menos flexível para buscas arbitrárias no meio da fila.