using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(10);
            bst.Insert(11);
            bst.Insert(9);
            bst.Insert(12);
            bst.Insert(19);
            bst.Insert(14);
            bst.Insert(18);
            bst.Insert(21);
            bst.Insert(2);
            bst.Insert(27);
            bst.Insert(22);
            bst.Insert(13);

            bst.Traverse(bst._root);
            Console.ReadLine();
        }
    }
}
