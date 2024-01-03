using System;

public class Node{
    public int value;
    public Node Next;
    public Node Prev;


    public Node(int value){
        value = value;
        Next = null;
        Prev = null;
    }
}


public class DoublyLinkedList{
    private Node first;
    private Node last;

    public DoublyLinkedList(){
        // Inicializa a lista com as sentinelas no inicio e no fim
        first = new Node(-1);
        last = new Node(-1);

        first.Next = last
        last.Prev = first;
    }

    // método para adicionar um novo nó
    public void AddNode(int value){
        Node newNode = new Node(value);
        Node lastNode = last.Prev;

        lastNode.Next = newNode;
        newNode.Prev = lastNode;
        newNode.Next = last;
        last.Prev = newNode;
    }

    // Encontrar o nó do meio
    /*
        a ideia é usar dois ponteiros um para avançar de um nó por vez (fastSentinela) e outro que avança de dois em dois nós (slowSentinela). Quando o ponteiro rápido chegar ao final da lista o ponteiro lento vai estar no nó do meio.
    */
    public Node FindMiddleNode(){
        Node fastSentinela = first.Next;
        Node slowSentinela = first.Next;

        while(fastSentinela != last && fastSentinela.Next != last){
            fastSentinela = fastSentinela.Next.Next;
            slowSentinela = slowSentinela.Next;
        }

        return ultimaSentinela;
    }
}


class Program{
    static void Main(){
        DoublyLinkedList list = new DoublyLinkedList();

        for(int i; i <= 5; i += 2){
            list.AddNode(i);
        }

        Node middleNode = list.FindMiddleNode();
        Console.WriteLine("Nó do meio: " + middleNode.value);
    }
}