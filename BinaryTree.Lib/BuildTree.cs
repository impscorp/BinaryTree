namespace BinaryTree.Lib;

public class BuildTree
{
    #region Properties

    public List<int> asc = new List<int>();
    public List<int> dec = new List<int>();
    public int Levels { get; set; } = 0;

    #endregion
    
    #region Methods
    /// <summary>
    /// Sorts the tree Ascending
    /// </summary>
    /// <param name="rootNode"></param>
    public void GetAsc(Node rootNode)
    {
        if (rootNode.Left != null) GetAsc(rootNode.Left);
        asc.Add(rootNode.ID);
        if (rootNode.Right != null) GetAsc(rootNode.Right);
    }
    /// <summary>
    /// Sorts the tree Descending
    /// </summary>
    /// <param name="rootNode"></param>
    public void GetDec(Node rootNode)
    {
        if (rootNode.Right != null) GetDec(rootNode.Right);
        dec.Add(rootNode.ID);
        if (rootNode.Left != null) GetDec(rootNode.Left);
    }
    
    public int GetLevels(Node rootNode)
    {
        if (rootNode.Left != null) GetLevels(rootNode.Left);
        if (rootNode.Right != null) GetLevels(rootNode.Right);
        Levels++;
        return Levels;
    }
    public Node BuildTreeFromList(List<int> list)
    {
        if (list.Count == 0) return null;
        var mid = list.Count / 2;
        var node = new Node(list[mid]);
        node.Left = BuildTreeFromList(list.GetRange(0, mid));
        node.Right = BuildTreeFromList(list.GetRange(mid + 1, list.Count - mid - 1));
        return node;
    }
    public void PrintTree(Node rootNode, int level)
    {
        if (rootNode.Right != null) PrintTree(rootNode.Right, level + 1);
        for (int i = 0; i < level; i++) Console.Write("   ");
        Console.WriteLine(rootNode.ID);
        if (rootNode.Left != null) PrintTree(rootNode.Left, level + 1);
    }
    public Node? Search(Node rootNode, int id)
    {
        if(rootNode == null || rootNode.ID == id)
        {
            return rootNode;
        }
        if(rootNode.ID < id)
        {
            return Search(rootNode.Right, id);
        }
        if(rootNode.ID > id)
        {
            return Search(rootNode.Left, id);
        }
        return null;
    }
    
    public void Insert(Node rootNode, int id)
    {
        if (rootNode.ID == id)
        {
            Console.WriteLine("ID already in tree");
            return;
        }
        if (rootNode.ID > id)
        {
            if (rootNode.Left == null)
            {
                rootNode.Left = new Node(id);
            }
            else
            {
                Insert(rootNode.Left, id);
            }
        }
        else
        {
            if (rootNode.Right == null)
            {
                rootNode.Right = new Node(id);
            }
            else
            {
                Insert(rootNode.Right, id);
            }
        }
    }
    

    public void Remove(Node rootNode, int id)
    {
        if (rootNode.Left != null)
        {
            if (rootNode.Left.ID == id)
            {
                rootNode.Left = null;
            }
            else
            {
                Remove(rootNode.Left, id);
            }
        }
        if (rootNode.Right != null)
        {
            if (rootNode.Right.ID == id)
            {
                rootNode.Right = null;
            }
            else
            {
                Remove(rootNode.Right, id);
            }
        }
    }
    
    
    #endregion
}