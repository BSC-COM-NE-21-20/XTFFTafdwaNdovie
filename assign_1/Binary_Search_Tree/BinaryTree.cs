using System;
//nullable enabled
//git link repo https://github.com/BSC-COM-NE-21-20/COM314-BSC-COM-NE-21-20.GIT

//BinaryTree class

public class BinaryTree<S> where S : IComparable<S>
{
    private ImplementingBinarySearchTree<S>? root;

    public void Insert(S value)
    {
        root = InsertRec(root, value);
    }

    private ImplementingBinarySearchTree<S>? InsertRec(ImplementingBinarySearchTree<S>? root, S value)
    {
        if (root == null)
        {
            root = new ImplementingBinarySearchTree<S>(value);
            return root;
        }

        if (value.CompareTo(root.Value) < 0)
        {
            root.Left = InsertRec(root.Left, value);
        }
        else if (value.CompareTo(root.Value) > 0)
        {
            root.Right = InsertRec(root.Right, value);
        }

        return root;
    }

    public ImplementingBinarySearchTree<S>? Search(S value)
    {
        return SearchRec(root, value);
    }

    private ImplementingBinarySearchTree<S>? SearchRec(ImplementingBinarySearchTree<S>? root, S value)
    {
        if (root == null || root.Value.Equals(value))
        {
            return root;
        }

        if (value.CompareTo(root.Value) < 0)
        {
            return SearchRec(root.Left, value);
        }

        return SearchRec(root.Right, value);
    }

    public bool Remove(S value)
    {
        if (root == null)
        {
            return false; // Tree is empty
        }

        root = RemoveNode(root, value);
        return root != null;
    }

    private ImplementingBinarySearchTree<S>? RemoveNode(ImplementingBinarySearchTree<S>? root, S value)
    {
 
        return root;
    }

    private S FindMinValue(ImplementingBinarySearchTree<S> node)
    {
        S minValue = node.Value;
        while (node.Left != null)
        {
            minValue = node.Left.Value;
            node = node.Left;
        }
        return minValue;
    }

    public void InorderTraversal()
    {
        InorderTraversal(root);
        Console.WriteLine();
    }

    private void InorderTraversal(ImplementingBinarySearchTree<S>? root)
    {
        if (root != null)
        {
            InorderTraversal(root.Left);
            Console.Write(root.Value + " ");
            InorderTraversal(root.Right);
        }
    }

    public void PostorderTraversal()
    {
        PostorderTraversal(root);
        Console.WriteLine();
    }

    private void PostorderTraversal(ImplementingBinarySearchTree<S>? root)
    {
        if (root != null)
        {
            PostorderTraversal(root.Left);
            PostorderTraversal(root.Right);
            Console.Write(root.Value + " ");
        }
    }
}
