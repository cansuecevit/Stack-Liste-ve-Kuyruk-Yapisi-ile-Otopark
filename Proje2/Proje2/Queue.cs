using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
   public interface Queue
    {
        void Insert(Araba a);
        int Remove();
        object Peek();
        Boolean IsEmpty();
        string Listele();
    }
}
