using System;
using System.Collections.Generic;


public class ArvoreSimples<T> {
    private No<T> raiz;
    private int tamanho;


    public ArvoreSimples(T o) {
        this.raiz = new No<T>(null, o);
        this.tamanho = 1;
    }


    public No<T> Root() {
        return this.raiz;
    }


    public No<T> Parent(No<T> v) {
        return v.Parent;
    }


    public List<No<T>> Children(No<T> v) {
        return v.Children;
    }


    public bool IsInternal(No<T> v) {
        return (v.Children.Count > 0);
    }


    public bool IsExternal(No<T> v) {
        return (v.Children.Count == 0);
    }


    public bool IsRoot(No<T> v) {
        return (v == this.raiz);
    }


    public No<T> AddChild(No<T> v, T o) {
        No<T> novo = new No<T>(v, o);
        v.Children.Add(novo);
        this.tamanho++;

        return novo;
    }


    public T Remove(No<T> v) {
        No<T> pai = v.Parent;
        
        if(pai != null || this.IsExternal(v)) {
            pai.Children.Remove(v);
        } else {
            throw new SystemException();
        }

        T o = v.Element;
        this.tamanho--;

        return o;
    }


    public void SwapElements(No<T> v, No<T> w) {
        T temp = v.Element;
        v.Element = w.Element;
        w.Element = temp;
    }


    public int Depth(No<T> v) {
        int profundidade = this.Profundidade(v);
        
        return profundidade;
    }

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
