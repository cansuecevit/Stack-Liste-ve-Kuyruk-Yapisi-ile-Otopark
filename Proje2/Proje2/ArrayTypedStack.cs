using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    public class ArrayTypedStack:IStack
    {
        public int[] items;
        private int top = -1;
        public int size = 0;
   

        public  ArrayTypedStack(int itemCount)
        {
            this.size = itemCount;
            this.items = new int[itemCount];
        
        }
        public void Push(Araba item)
        {
            if(items.Length == Top + 1)
            {
                throw new Exception("Hata:Stack doldu..");
            }
            items[++Top] = item.ArabaNo;
        }
        public int Pop()
        {
            if(IsEmpty())
            {
                throw new Exception("Hata:Stack boş..");
            }
            int temp = items[Top--];
            size--;
            return temp;
        }
        public object Peek()
        {
            return items[Top];
        }
        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }
        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }


    }
}
