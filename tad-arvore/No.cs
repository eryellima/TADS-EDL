using System;
using System.Collections.Generic;


public class No<T> {
    private T o;
    private No<T> pai;
    private List<No<T>> filhos = new List<No<T>>();


    public No(No<T> pai, T o) {
        this.pai = pai;
        this.o = o;
    }


    public T Element {
        get {
            return this.o;
        }

        set {
            this.o = value;
        }
    }


    public No<T> Parent {
        get {
            return this.pai;
        }
    }


    public List<No<T>> Children {
        get {
            return this.filhos;
        }
    }
}
