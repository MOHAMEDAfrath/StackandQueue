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
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Empty Stack");
                return;
            }
            else
            {
                Console.WriteLine("Poped {0}",this.top.data);
            }
            this.top = this.top.next;
        }
        public void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("Empty Stack");
            }
            else
            {
                Console.WriteLine("The value at top of stack {0}",this.top.data);
            }
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data+ " ");
                temp = temp.next;
            }
            Console.WriteLine(" ");
        }
    }
}
