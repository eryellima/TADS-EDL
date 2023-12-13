public class ArvoreBinariaPesquisa<T> where T : IComparable<T> {
    private Node<T> root;

    public ArvoreBinariaPesquisa() {
        root = null;
    }


    // Retorna a rai da árvore
    public Node<T> Root() {
        return root;
    }

    // Retorna o filho à esquerda de um nó
    public Node<T> LeftChild(Node<T> v) {
        return v.Left;
    }


    // Retorna o filho à direita de um nó
    public Node<T> RightChild(Node<T> v) {
        return v.Right;
    }

    // Verifica se um nó tem filho esqeurdo
    public bool HasLeft(Node<T> v) {
        return v.Left != null;
    }

    // Verifica se um nó tem um filho direito
    public bool HasRight(Node<T> v) {
        return v.Right != null;
    }

    // Encontra um nó com a chave fornecida na árvore
    public Node<T> Find(T key) {
        return Find(root, key);
    }

    private Node<T> Find(Node<T> node, T key) {
        if(node == null || key.Equals(node.Key)) {
            return node;
        }

        if(key.CompareTo(node.Key) < 0) {
            return Find(node.Left, key);
        } else {
            return Find(node.Right, key);
        }
    }


    // Insere uma chave na árvore
    public void Insert(T key) {
        root = Insert(root, key, null);
    }

    private Node<T> Insert(Node<T> node, T key, Node<T> parent) {
        if(node == null) {
            return new Node<T>(key, parent);
        }

        if(key.CompareTo(node.Key) < 0) {
            node.Left = Insert(node.Left, key, node);
        }
        
        else if(key.CompareTo(node.Key) > 0) {
            node.Right = Insert(node.Right, key, node);
        }

        return node;
    }


    // Remove um nó com a chave fornecida
    public void Remove(T key) {
        root = Remove(root, key);
    }

    private Node<T> Remove(Node<T> node, T key) {
        if(node == null) {
            return null;
        }

        if(key.CompareTo(node.Key) < 0) {
            node.Left = Remove(node.Left, key);
        }
        
        else if(key.CompareTo(node.Key) > 0) {
            node.Right = Remove(node.Right, key);
        } else {
            if(node.Left == null) {
                return node.Right;
            }
            
            else if(node.Right == null) {
                return node.Left;
            }

            node.Key = MinValue(node.Right);
            node.Right = Remove(node.Right, node.Key);
        }

        return node;
    }


    // Encontra o vlaor mínimo na árvore
    private T MinValue(Node<T> node) {
        T minValue = node.Key;
        while(node.Left != null) {
            minValue = node.Left.Key;
            node = node.Left;
        }
        return minValue;
    }


    // Desenha a árvore
    public void PrintTree() {
        Console.WriteLine("Árvore Binária de Pesquisa:");
        PrintTree(this.root, "", true);
    }

    private void PrintTree(Node<T> node, string indent, bool last) {
        if (node != null) {
            Console.Write(indent);
            if(last) {
                Console.Write("└─ ");
                indent += "   ";
            } else {
                Console.Write("├─ ");
                indent += "│  ";
            }

            Console.WriteLine($"{node.Key}");

            PrintTree(node.Left, indent, false);
            PrintTree(node.Right, indent, true);
        }
    }
}
