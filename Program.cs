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
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
