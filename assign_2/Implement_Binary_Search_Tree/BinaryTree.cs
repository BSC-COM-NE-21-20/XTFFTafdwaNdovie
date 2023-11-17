
public class BinaryTree
{
    // Change the access modifier to internal
    internal ImplementingBinarySearchTree root; 

    public void Insert(Person person)
    {
        root = InsertRec(root, person);
    }

    //inserting data
    private ImplementingBinarySearchTree InsertRec(ImplementingBinarySearchTree root, Person person)
    {
        if (root == null)
        {
            return new ImplementingBinarySearchTree(person);
        }

        //handling the age constraints
        if (person.Age < root.Data.Age)
        {
            root.Left = InsertRec(root.Left, person);
        }
        else if (person.Age > root.Data.Age)
        {
            root.Right = InsertRec(root.Right, person);
        }
        else
        {
            // Handle cases where ages are the same (optional).
            // You can decide how to handle these cases, e.g., ignore or update the existing node.
            root.Data = person;
        }

        return root;
    }

    public ImplementingBinarySearchTree Search(string uniqueID)
    {
        return SearchRec(root, uniqueID);
    }

    private ImplementingBinarySearchTree SearchRec(ImplementingBinarySearchTree root, string uniqueID)
    {
        if (root == null || root.Data.UniqueID == uniqueID)
        {
            return root;
        }

        if (string.Compare(uniqueID, root.Data.UniqueID, StringComparison.OrdinalIgnoreCase) < 0)
        {
            return SearchRec(root.Left, uniqueID);
        }

        return SearchRec(root.Right, uniqueID);
    }

    public void InorderTraversal(ImplementingBinarySearchTree node)
    {
        if (node != null)
        {
            InorderTraversal(node.Left);
            Console.WriteLine($"First Name: {node.Data.FirstName}, Last Name: {node.Data.LastName}, Age: {node.Data.Age}, Unique ID: {node.Data.UniqueID}");
            InorderTraversal(node.Right);
        }
    }

    public void PostorderTraversal(ImplementingBinarySearchTree node)
    {
        if (node != null)
        {
            PostorderTraversal(node.Left);
            PostorderTraversal(node.Right);
            Console.WriteLine($"First Name: {node.Data.FirstName}, Last Name: {node.Data.LastName}, Age: {node.Data.Age}, Unique ID: {node.Data.UniqueID}");
        }
    }
}