using System;

public class ImplementingBinarySearchTree<S>
{
    public S Value { get; set; }
    public ImplementingBinarySearchTree<S>? Left { get; set; }
    public ImplementingBinarySearchTree<S>? Right { get; set; }

    public ImplementingBinarySearchTree(S value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}
