using BinaryTree.Lib;

List<int> input = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
input.Sort();
BuildTree bt = new BuildTree();

var x = bt.BuildTreeFromList(input);

while (true)
{
    

Console.WriteLine("what to do?");
var choice = Console.ReadLine();


    switch (choice)
    {
        case "asc":
            bt.asc.Clear();
            bt.GetAsc(x);
            foreach (var d in bt.asc)
            {
                Console.WriteLine(d);
            }
            break;
        case "dec":
            bt.dec.Clear();
            bt.GetDec(x);
            foreach (var d in bt.dec)
            {
                Console.WriteLine(d);
            }
            break;
        case "search":
            Console.WriteLine("what to search?");
            var search = Console.ReadLine();
            var n = bt.Search(x, int.Parse(search));
            Console.WriteLine(n.ID);
            break;
        case "insert":
            Console.WriteLine("what to insert?");
            var insert = Console.ReadLine();
            bt.Insert(x, int.Parse(insert));
            break;
        case "remove":
            Console.WriteLine("what to remove?");
            var remove = Console.ReadLine();
            bt.Remove(x, int.Parse(remove));
            break;
        case "print":
            bt.PrintTree(x, 0);
            break;
        case "exit":
            Environment.Exit(0);
            break;
        case "help":
            Console.WriteLine("asc, dec, search, insert, remove, print, exit, help");
            break;
        default:
            break;
    }
}


