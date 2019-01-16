using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    public class Otoparkımız
    {
        public CircularQueue c = new CircularQueue(15);
        public ArrayTypedStack s = new ArrayTypedStack(15);
        public LinkedList l = new LinkedList();

        public Otoparkımız()
        {
           
            for (int i = 0; i < 15; i++)
            {
                Araba a = new Araba();
                a.ArabaNo = i + 1;
                c.Insert(a);
            }
            for (int i = 0; i < 15; i++)
            {
                Araba a = new Araba();
                a.ArabaNo = i + 16;
                s.Push(a);
            }
            for(int i = 0; i<15; i++)
            {
                Araba a = new Araba();
                a.ArabaNo = i + 31;
                l.InsertLast(a);
            }
        }

    }
}


    
