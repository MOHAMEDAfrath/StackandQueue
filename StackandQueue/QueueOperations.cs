using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    class QueueOperations
    {
        Node front = null,rear = null;
        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if(this.front == null)
            {
                newnode.next = null;
                this.front = newnode;
                this.rear = newnode;
            }
            else
            {
                this.rear.next = newnode;
                this.rear = newnode;
            }
            Console.WriteLine("Enqueued {0}",data);
        }
        public void Display()
        {
            Node temp = this.front;
            while (temp != null)
            {
                Console.Write(temp.data+ " ");
                temp = temp.next;
            }
            Console.WriteLine(" ");
        }

    }
}
