using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    public abstract class ListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(Araba value);
        public abstract int DeleteFirst();
        public abstract string DeletePos(int position,Araba value);
        public abstract string DisplayElements();
        public abstract void InsertLast(Araba value);

    }
}
