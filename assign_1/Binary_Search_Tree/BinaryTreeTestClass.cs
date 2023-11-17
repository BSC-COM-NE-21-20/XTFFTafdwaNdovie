using System;

//BinaryTreeTestClass, run test class
public class BinaryTreeTestClass
{
    public static void TestingMethod()
    {
        BinaryTree<int> tree = new BinaryTree<int>();

        tree.Insert(1);
        tree.Insert(2);
        tree.Insert(3);
        tree.Insert(4);
        tree.Insert(5);
        tree.Insert(6);
     

        Console.WriteLine("Inorder Traversal:");
        tree.InorderTraversal();

        Console.WriteLine("Postorder Traversal:");
        tree.PostorderTraversal();

        int valueToSearch = 6;
        ImplementingBinarySearchTree<int>? searchResult = tree.Search(valueToSearch);
        Console.WriteLine($"Searching for value {valueToSearch}: {(searchResult != null ? "Value exists" : "Does not exist")}");


        int valueToRemove = 3;
        bool removeResult = tree.Remove(valueToRemove);
        Console.WriteLine($"Removing value {valueToRemove}: {(removeResult ? "Removed" : "Not Found")}");

        Console.WriteLine("Inorder Traversal after removal:");
        tree.InorderTraversal();
    }
}
