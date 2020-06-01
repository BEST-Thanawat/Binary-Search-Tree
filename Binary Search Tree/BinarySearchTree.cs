using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    public class BinarySearchTree
    {
        public Node _root;
        public BinarySearchTree()
        {
            _root = null;
        }
        public void Insert(int i)
        {
            //Create new node
            Node newNode = new Node();
            newNode.Data = i;

            //Return newNode as a root
            if (_root == null) _root = newNode;

            //Loop through the tree
            else
            {
                Node current = _root;
                Node parent = null;
                while (true)
                {
                    parent = current;
                    if (i < current.Data) //Left Node
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right; //Right Node
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        //Traversal the tree
        public void Traverse(Node node)
        {
            if (node == null) return;

            Console.WriteLine(node.Data);
            Traverse(node.Left);
            Traverse(node.Right);
        }
    }
}
