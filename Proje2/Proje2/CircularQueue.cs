using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public class CircularQueue : Queue
    {
        public int[] Queue;
        public int front = -1;
        private int rear = -1;
        private int size = 0;
        public int count = 0;

        public CircularQueue(int size)
        {
            this.size = size;
            Queue = new int[size];
        }
        public void Insert(Araba a)
        {
            if (count == size)
                throw new Exception("Kuyruk dolu.");
            if (front == -1)
                front = 0;
            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = a.ArabaNo;
            }
            else
                Queue[++rear] = a.ArabaNo;
            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public object Peek()
        {
            return Queue[front];
        }

        public int Remove()
        {
            int temp = Queue[front];
            Queue[front] = '\0';
            if (front == size - 1)
                front = 0;
            else
                front++;
            count--;
            return temp;
        }
        public string Listele()
        {
            string temp = "";
            for(int i = 0; i<15; i++)
            {
                temp += "Araba No:  " + (Queue[i]).ToString() + Environment.NewLine ;
        }
            return temp;

        }

    }
}
