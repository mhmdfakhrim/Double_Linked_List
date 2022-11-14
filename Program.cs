using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Linked_List
{

    class Node
    {
        /*Node class represents the node of doubly linked list.
         * it consists of the information part and links to
         * its succeeding and preceeding
         * in terms of next and previous */
        public int noMhs;
        public string name;
        //point to the succeeding node
        public Node next;
        //point to the preceeding node
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;

        //constructor

        public DoubleLinkedList()
        {
            START = null;
        }

        public void addNode()
        {
            int nim;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            //check if the list empty
            if (START == null) || nim <= START.noMhs;)
                    if ((START != null) && (nim == START.noMhs))
            {
                Console.WriteLine("\nDuplicate number not allowed");
                return;
            }
            newNode.next = START;
            if (START != null)
                START.prev = newNode;
            newNode.prev = null;
            START = newNode;
            return;

            /* if the node is to be inserted at between two node*/
            Node previous, current;
            for (current = previous = START;
                current != null && nim >= current.noMhs;
                previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return ;
                }
            }
            /*On the execution of the above for loop, prev and 
             * * current will point to these nodes
             * * between wich the new node is to be inserted */
            newNode.next = current;
            newNode.prev = previous;
            
            //if the node is to be issarted at the end of the list 
            if(current == null)
            {
                newNode.next = null;
                newNode.next = newNode;
                return ;
            }
            current.prev = newNode;
            previous.next = newNode;    
        }
        public bool search (int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = START; current != null; && rollNo != current.noMhs; previous = current, current = current.next){ }
            return (current != null);
        }
        public bool dellNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (search(rollNo, ref previous, ref current) == false)
                return false;
            //the beginning of data
            if (current == null)
            {
                previous.next = null;
                return true;
            }    
            //node between two nodes in the list
            if (current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true ;
            }
            /*
             * if the to deleted is in between the list then the following lines of is executed
             */
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }

        public void ascending()
        {
            if (listEmpty())
                Console.WriteLine("\nList is Empty");
            else
            {
                Console.WriteLine("\nRecord in the ascending order of" + "roll number are:\n")
                    Node currentNode;
            }
        }

    }
}
