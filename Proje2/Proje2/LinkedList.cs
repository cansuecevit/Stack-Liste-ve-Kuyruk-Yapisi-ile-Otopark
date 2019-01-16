using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    public class LinkedList:ListADT
    {
        public override void InsertFirst(Araba value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };
            if(Head==null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;
        }
        public override string DeletePos(int position,Araba value)
        {
            string temp = "";
            Node tempNode = Head;
            Node lastNode = null;
            while(tempNode !=null)
            {
                if (tempNode.Data.ArabaNo == position)
                {
                    lastNode = tempNode;
                    tempNode.Data.ArabaNo = '\0';
                }
                tempNode = tempNode.Next;
            }
            return temp;    
        }
        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while(item!=null)
            {
                temp += "Araba No:   " + item.Data.ArabaNo + Environment.NewLine;
                item = item.Next;
            }
            return temp;
        }
        public override int DeleteFirst()
        {
            int deger = Head.Data.ArabaNo;
            if (Head != null)
            {
                Node tempHeadNext = this.Head.Next;
                if (tempHeadNext == null)
                    Head = null;
                else
                    Head = tempHeadNext;
   
                Size--;
            }
            return deger;
        }
        public override void InsertLast(Araba value)
        {
            Node oldLast = Head;

            if (Head == null)
                InsertFirst(value);
            else
            {
                Node newLast = new Node
                {
                    Data = value
                };
                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                        oldLast = oldLast.Next;
                    else
                        break;
                }
                oldLast.Next = newLast;
                Size++;
            }
        }


    }
}
