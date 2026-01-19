using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            list.head.next = second;
            second.next = third;

            list.push(23);
            list.append(20);
            list.insert_after(second, 26);
            list.insert_after(third, 23);
            list.deleteNode(1);
            list.printList();
        }
    }
}
