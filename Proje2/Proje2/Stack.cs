using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    public interface IStack
    {
        void Push(Araba item);
        int Pop();
        object Peek();
        bool IsEmpty();
        int Top { get; set; }
 
    }
}
