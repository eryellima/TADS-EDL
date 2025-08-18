# 📌 TAD Sequência
Uma **Sequência** é um **TAD genérico** que unifica as ideias de **vetor (acesso por índice)** e **lista (inserção/remoção flexível)**.
Ela representa uma **coleção linear de elementos ordenados**, onde cada posição (índice) tem um valor associado.

---

## 🧩 Ideia básica
- Estrutura linear que **combina as operações de listas e vetores**.
- Permite acessar elementos por **posição (índice)**, como em um vetor.
- Permite inserção e remoção em qualquer posição, como em uma lista encadeada.
- Pode ser implementada sobre **vetores dinâmicos** ou **listas duplamente encadeadas**.

---

## 🔄 Operações principais
- **InsertAt(i, x):** insere elemento `x` na posição `i`.
- **RemoveAt(i):** remove o elemento da posição `i`.
- **GetAt(i):** retorna o elemento na posição `i`.
- **SetAt(i, x):** substitui o elemento da posição `i` por `x`.
- **First():** retorna o primeiro elemento.
- **Last():** retorna o último elemento.
- **Size():** retorna o número de elementos.
- **IsEmpty():** verifica se a sequência está vazia.

---

## 📊 Estrutura visual

Exemplo de **Sequência de 5 elementos**:
~~~yaml
Índice:   0    1    2    3    4
Valores: [A]  [B]  [C]  [D]  [E]
~~~

* Inserir `X` na posição 2:
~~~yaml
[A] → [B] → [X] → [C] → [D] → [E]
~~~

* Remover na posição 4:
~~~~yaml
[A] → [B] → [X] → [C] → [E]
~~~~

---

## ⚙️ Complexidade média
Depende da **implementação**:

| Operação                  | Vetor Dinâmico  | Lista Dupla |
| ------------------------- | --------------- | ----------- |
| Acesso direto             | O(1)            | O(n)        |
| Inserção/remoc. no início | O(n)            | O(1)        |
| Inserção/remoc. no fim    | O(1) amortizado | O(1)        |
| Inserção/remoc. no meio   | O(n)            | O(n)        |
| Tamanho (Size)            | O(1)            | O(1)        |

---

## 👍 Vantagens
* Estrutura **flexível**, unindo características de vetor e lista.
* Permite acesso por **índice** e também inserções/remoções arbitrárias.
* Pode ser adaptada conforme o uso (melhor em vetor ou lista).
* Serve como **base para outros TADs** como pilhas, filas e deques.

---

## 👎 Desvantagens
- Mais complexa de implementar que um vetor ou lista isolados.
- Dependendo da implementação, algumas operações ficam caras:

  - Em vetor dinâmico: **inserções no meio custam O(n)**.
  - Em lista: **acesso direto custa O(n)**.
- Consome mais memória se mantiver ponteiros extras (listas duplas).
