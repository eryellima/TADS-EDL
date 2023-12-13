public class Node<T> {
    public T Key { get; set; }
    public Node<T> Parent { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }

    public Node(T key, Node<T> parent = null, Node<T> left = null, Node<T> right = null) {
        Key = key;
        Parent = parent;
        Left = left;
        Right = right;
    }
}
