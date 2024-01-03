using System;

public class SkipNode<T> where T : IComparable<T>{
    public T Key { get; set; }
    public object Value { get; set; }

    // Links
    public SkipNode<T> Up, Down, Next, Prev;

    public SkipNode(T key, object value){
        Key = key;
        Value = value;
    }
}
