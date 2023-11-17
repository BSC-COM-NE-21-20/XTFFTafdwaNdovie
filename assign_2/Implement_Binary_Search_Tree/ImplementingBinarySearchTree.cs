//creating class ImplementingBinarySearchTree
//which has Person data-type and ImplementingBinarySearchTree

public class ImplementingBinarySearchTree
{
    public Person Data { get; set; }
    public ImplementingBinarySearchTree Left { get; set; }
    public ImplementingBinarySearchTree Right { get; set; }

    public ImplementingBinarySearchTree(Person data)
    {
        Data = data;
        Left = null; //initializing left and right to null values
        Right = null;
    }
}
