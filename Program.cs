using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Ryan Clark
//Implementing a Binary Search Tree and Depth First Search and Breadth First Search of the BST


namespace DFS
{   
        class Node
        {
            int data;
            Node left, right;
            
            public Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }

            public void InsertNode(int num)
            {
                Node temp = this;
                while (temp != null)
                {
                    if (temp.data > num)
                    {
                        if (temp.left == null)
                        {
                            temp.left = new Node(num);
                            break;
                        }
                        else
                        {
                            temp = temp.left;
                        }
                    }
                    else
                    {
                        if (temp.right == null)
                        {
                            temp.right = new Node(num);
                            break;
                        }
                        else
                        {
                            temp = temp.right;
                        }
                    }
                }
            }



            //Display BST
            public void PreOrderBST(Node root)
            {
                if (root != null)
                {
                    Console.WriteLine(root.data + " ");
                    PreOrderBST(root.left);
                    PreOrderBST(root.right);
                }
            }



            public void InOrderBST(Node root)
            {
                if (root != null)
                {
                    InOrderBST(root.left);
                    Console.WriteLine(root.data + " ");
                    InOrderBST(root.right);
                }
            }

            public void PostOrderBST(Node root)
            {
                if (root != null)
                {
                    PostOrderBST(root.left);
                    PostOrderBST(root.right);
                    Console.WriteLine(root.data + " ");
                }
            }

            public void BreadthBST(Node root)
            {
                Node start;
                Queue<Node> bread = new Queue<Node>();
                bread.Enqueue(root);
                while(bread.Count != 0){
                    start = bread.Dequeue();
                    Console.WriteLine(start.data+ " ");
                    if (start.left != null)
                    {
                        bread.Enqueue(start.left);
                    }
                    if (start.right != null)
                    {
                        bread.Enqueue(start.right);
                    }
                }
            }
        }
       
    
    class Program
    {
        static void Main(string[] args)
        {

            Node root = new Node(22);
            root.InsertNode(33);
            root.InsertNode(5);
            root.InsertNode(6);
            root.InsertNode(8);
            root.InsertNode(38);
            root.InsertNode(30);
            root.InsertNode(4);



            Console.WriteLine("Pre-order First Search");
            root.PreOrderBST(root);

            Console.WriteLine("In-order First Search");
            root.InOrderBST(root);

            Console.WriteLine("Post-order First Search");
            root.PostOrderBST(root);

            Console.WriteLine("Breadth-first Search");
            root.BreadthBST(root);

        }
    }
}
