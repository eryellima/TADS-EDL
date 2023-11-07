using System;
using System.Collections.Generic;


public class ArvoreSimples<T> {
    private No<T> raiz;
    private int tamanho;


    public ArvoreSimples(T o) {
        this.raiz = new No<T>(null, o);
        this.tamanho = 1;
    }


    // Acessa o nó raiz da arvore
    public No<T> Root() {
        return this.raiz;
    }

    
    // Tenta obter o pai de um nó
    public No<T> Parent(No<T> v) {
        return v.Parent;
    }


    // Obtem a lista de filhos de um nó
    public List<No<T>> Children(No<T> v) {
        return v.Children;
    }


    // Retornam true se o nó for interno
    public bool IsInternal(No<T> v) {
        return (v.Children.Count > 0);
    }


    // Retorna true se o nó for um nó externo
    public bool IsExternal(No<T> v) {
        return (v.Children.Count == 0);
    }


    // Verifica se o nó é a raiz
    public bool IsRoot(No<T> v) {
        return (v == this.raiz);
    }


    // Adiciona um novo nó como filho
    public No<T> AddChild(No<T> v, T o) {
        No<T> novo = new No<T>(v, o);
        v.Children.Add(novo);
        this.tamanho++;

        return novo;
    }


    // Remove um né da árvore
    public T Remove(No<T> v) {
        No<T> pai = v.Parent;

        // Verifican se o o nó é a raiz da árvore ou se ele não tem filhos
        if(pai != null || this.IsExternal(v)) {
            pai.Children.Remove(v);
        } else {
            throw new SystemException();
        }

        T o = v.Element;
        this.tamanho--;

        return o;
    }


    // Troca os valores do nó existente
    public void SwapElements(No<T> v, No<T> w) {
        T temp = v.Element;
        v.Element = w.Element;
        w.Element = temp;
    }


    public int Depth(No<T> v) {
        int profundidade = this.Profundidade(v);
        
        return profundidade;
    }
    
    // Retorna a profundidade
    private int Profundidade(No<T> v) {
        if(v == this.raiz) {
            return 0;
        } else {
            return (1 + this.Profundidade(v.Parent));
        }
    }


    public int Height() {
        return Height(this.raiz);
    }

    // Retorna a altura
    private int Height(No<T> node) {
        if (node == null) {
            return 0;
        }

        int max_child_height = 0;

        foreach (No<T> child in node.Children) {
            int child_height = Height(child);

            if(child_height > max_child_height) {
                max_child_height = child_height;
            }
        }

        return 1 + max_child_height;
    }


    public IEnumerable<T> Elements() {
        return Elements(this.raiz);
    }

    private IEnumerable<T> Elements(No<T> node) {
        yield return node.Element;

        foreach(No<T> child in node.Children) {
            foreach(T element in Elements(child)) {
                yield return element;
            }
        }
    }


    public IEnumerable<No<T>> Nodes() {
        return Nodes(this.raiz);
    }

    private IEnumerable<No<T>> Nodes(No<T> node) {
        yield return node;

        foreach(No<T> child in node.Children) {
            foreach(No<T> child_node in Nodes(child)) {
                yield return child_node;
            }
        }
    }


    public int Size() {
        return this.tamanho;
    }


    public bool IsEmpty() {
        return this.tamanho == 0;
    }


    public T Replace(No<T> v, T o) {
        T oldElement = v.Element;
        v.Element = o;

        return oldElement;
    }


    // Desenha a árvore
    public void PrintTree(No<T> node, string indent = "", bool last = true) {
        if(node == null) {
            return;
        }

        Console.Write(indent);
    
        if (last) {
            Console.Write("└─ ");
            indent += "    ";
        } else {
            Console.Write("├─ ");
            indent += "│   ";
        }

        Console.WriteLine(node.Element + "(Nó " + node.Element + ")");

        if (node.Children.Count > 0) {
            for (int i = 0; i < node.Children.Count; i++) {
                PrintTree(node.Children[i], indent, i == node.Children.Count - 1);
            }
        }
    }
}
