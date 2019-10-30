using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree singleLinkedList = new BinarySearchTree();
            singleLinkedList.Add(60);
            singleLinkedList.Add(40);
            singleLinkedList.Add(110);
            singleLinkedList.Search(110);
        }        
    }
}
