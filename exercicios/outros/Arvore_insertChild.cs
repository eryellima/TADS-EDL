using System;
using System.Collections.Generic;


public class Node<T>{
    public T Value{
        get;
    }

    public List<Node<T>> Children{
        get;
    }

    public Node(T value){
        Value = value;
        Children = new List<Node<T>>();
    }
}


public class Arvore_Generica<T>{
    private Node<T> root;

    public Arvore_Generica(T rootValue){
        root = new Node<T>(rootValue);
    }


    /*
        Tenta encontrar o nó com o valor fornecido na árvore e, se encontrar, adicionar um novo nó como filho desse nó.
    */
    public void InserChild(T parentValue, T childValue){
        Node<T> parentNode = FindNode(root, pareentValue);

        if(parentNode != null){
            Node<T> newChild = new Node<T>(childValue);
            parentNode.Children.Add(newChild);
        } else{
            Console.WriteLine("$Valor {parentValue} não encontrado na árvore.");
        }
    }


    private Node<T> FindNode(Node<T> currentNode, T targetValue){
        if(EqualityComparer<T>.Default.Equals(currentNode.Value, targetValue)){
            return currentNode;
        }

        foreach(var child in currentNode.Children){
            Node<T> result = FindNode(child, targetValue);

            if(result != null){
                return result;
            }
        }

        return null;
    }
}


class Program{
    static void Main(){
        Arvore_Generica<int> arvore = new Arvore_Generica(1);

        // Inserindo alguns nós
        arvore.InserChild(1, 2);
        arvore.InserChild(1, 3);
        arvore.InserChild(2, 4);
        arvore.InserChild(2, 5);

        // tentando inserir um nó que não existe
        arvore.InserChild(8, 9);

        // mostrnado a árvore
        Console.WriteLine("Árvore:")
        Print_Arvore(arvore);
    }

    static void Print_Arvore<T>(Arvore_Generica<T> arvore){
        Print_Node(arvore, arvore.Root, 0);
    }

    static void Print_Node<T>(Arvore_Generica<T> arvore, Node<T> node, int profundidade){
        Console.WriteLine($"{new string(' ', profundidade * 2)}{node.Value}");

        foreach(var child in node.Children){
            Print_Node(arvore, child, profundidade + 1);
        }
    }
}
