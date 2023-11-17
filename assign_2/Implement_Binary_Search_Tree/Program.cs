//allow the Pogram to use system classes
//This is the implementing_Binary_Search-Tree program from assignment 1
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();

        // Read data from "COM314.txt file" 
        //and insert it into the binary tree
        string filePath = "./COM314.txt";

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            Person newPerson = null;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (newPerson != null)
                    {
                        tree.Insert(newPerson);
                        newPerson = null;
                    }
                }

                //if person is null, create a person/insert a new person
                else if (newPerson == null) 
                {
                    string[] parts = line.Split(' ');
                    if (parts.Length == 4)
                    {
                        string firstName = parts[0];
                        string lastName = parts[1];
                        int age = int.Parse(parts[2]);
                        string uniqueID = parts[3];
                        newPerson = new Person(firstName, lastName, age, uniqueID);
                    }
                }
            }
        }
        else
        {
                //if file does not exist
            Console.WriteLine("The file 'COM314.txt' does not exist in the current folder.");
            return;
        }

        // Display traversal options to the user
        Console.WriteLine("Choose traversal type:");
        Console.WriteLine("1. Inorder");
        Console.WriteLine("2. Postorder");

        int choice; //handle cases where the user has made some choices
        if (int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2))
        {
            if (choice == 1)
            {
                    //display in order
                Console.WriteLine("Inorder Traversal:");
                tree.InorderTraversal(tree.root);
            }
            else
            {
                    //reverse order
                Console.WriteLine("Postorder Traversal:");
                tree.PostorderTraversal(tree.root);
            }
        }
        else
        {
            // display error message when wrong choice entered/typed
            Console.WriteLine("Invalid choice. Please enter 1 for Inorder or 2 for Postorder.");
        }

        // Allow the user to search for a person by Unique ID
        //from the COM314.txt file
        Console.WriteLine("Enter the Unique ID to search for:");
        string searchID = Console.ReadLine();

        ImplementingBinarySearchTree searchResult = tree.Search(searchID);
        if (searchResult != null)
        {
            //if person exists
            Console.WriteLine($"Person found - First Name: {searchResult.Data.FirstName}, Last Name: {searchResult.Data.LastName}, Age: {searchResult.Data.Age}, Unique ID: {searchResult.Data.UniqueID}");
        }
        else
        {
            //if a person does not exist
            Console.WriteLine("Person with the given Unique ID not found.");
        }
    }
}
