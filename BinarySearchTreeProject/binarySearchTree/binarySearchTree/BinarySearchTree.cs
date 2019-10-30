﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    public class BinarySearchTree
    {
        //METHOD VARIABLES
        Node root;

        //CONSTRUCTOR

        public BinarySearchTree()
        {
            root = null;
        }

        //MEMBER METHODS
        public Node Add(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                return root;
            }
            Node temp = root;
            if (data <= root.data)
            {
                while (temp.leftChild != null)
                {
                    temp = temp.leftChild;
                }
                temp.leftChild = node;
                return node;
            }
            else
            {
                while (temp.rightChild != null)
                {
                    temp = temp.rightChild;
                }
                temp.rightChild = node;
                return node;
            }
        }
        public void Search(int data)
        {
            Node temp = root;
            if (data <= root.data)
            {
                if (data == temp.data)
                {
                    Console.WriteLine("Found the node: " + data);
                    Console.ReadLine();
                }
                else
                {
                    while (temp.leftChild != null)
                    {
                        temp = temp.leftChild;
                        if (data == temp.data)
                        {
                            Console.WriteLine("Found node: " + data);
                            Console.ReadLine();
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            else
            {
                if (data == temp.data)
                {
                    Console.WriteLine("Found node: " + data);
                    Console.ReadLine();
                }
                else
                {
                    while (temp.rightChild != null)
                    {
                        temp = temp.rightChild;
                        if (data == temp.data)
                        {
                            Console.WriteLine("Found node: " + data);
                            Console.ReadLine();
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}
