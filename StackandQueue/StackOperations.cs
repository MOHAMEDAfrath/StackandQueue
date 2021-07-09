using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    class StackOperations
    {
        Node top = null;
        public void Push(int data)
        {
            Node newnode = new Node(data);
            if(top == null)
            {
                newnode.next = null;
            }
            else
            {
                newnode.next = this.top;
            }
            this.top = newnode;
            Console.WriteLine("Successfully Inserted {0}",data);

        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data+ " ");
                temp = temp.next;
            }
        }
    }
}
