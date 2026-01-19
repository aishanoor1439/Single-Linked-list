using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    internal class LinkedList
    {
        public Node head;

        public void push(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = head;
            head = new_node;
        }

        public void append(int new_data)
        {
            Node new_node = new Node(new_data);
            if (head == null)
            {
                head = new Node(new_data);
                return;
            }
            new_node.next = null;
            Node last = head;
            while (last.next != null) {
            last = last.next;
            }
            last.next = new_node;
            new_node.next = null;
            return;
        }

        public void insert_after(Node prey_node, int new_data)
        {
            if(prey_node == null)
            {
                Console.WriteLine("The given previous node cannot be null.");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prey_node.next;
            prey_node.next = new_node;
        }

        public void deleteNode(int key)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            if(head.data == key)
            {
                head = head.next;
                return;
            }
            Node temp = head;
            while(temp.next != null && temp.next.data != key)
            {
                temp = temp.next;
            }
            if(temp.next == null)
            {
                Console.WriteLine("Value not found in the list.");
                return;
            }
            temp.next = temp.next.next;
        }
        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.data + "->");
                n = n.next;
            }
        }
    }
}
