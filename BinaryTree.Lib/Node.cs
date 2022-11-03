namespace BinaryTree.Lib;

public class Node
{
    #region Properties
    
    public int ID;
    public int Level;
    public Node? Left;
    public Node? Right;
    #endregion

    #region Constructors

    public Node(int id)
    {
        ID = id;
        Left = null;
        Right = null;
    }
    
    #endregion

    
}