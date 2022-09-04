using System;
using System.Collections.Generic;

namespace CSharpProject.Snippets;

internal class CliWriteTreeSample
{
    private const string _cross = " ├─";
    private const string _corner = " └─";
    private const string _vertical = " │ ";
    private const string _space = "   ";

    private static void Sample()
    {
        var topLevelNodes = CreateNodeList();

        topLevelNodes.ForEach(item => PrintNode(item, ""));
    }

    private static void PrintNode(Node node, string indent)
    {
        Console.WriteLine(node.Title);

        var numberOfChildren = node.Children.Length;
        for (var i = 0; i < numberOfChildren; i++)
        {
            var child = node.Children[i];
            var isLast = i == numberOfChildren - 1;
            PrintChildNode(child, indent, isLast);
        }
    }

    private static void PrintChildNode(Node node, string indent, bool isLast)
    {
        Console.Write(indent);

        if (isLast)
        {
            Console.Write(_corner);
            indent += _space;
        }
        else
        {
            Console.Write(_cross);
            indent += _vertical;
        }

        PrintNode(node, indent);
    }

    private static List<Node> CreateNodeList()
    {
        return null; // add your stuff here
    }

    private class Node
    {
        public bool Title { get; internal set; }
        public Node[] Children { get; internal set; }
    }
}