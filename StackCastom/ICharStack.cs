using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCastom
{
    public interface ICharStack
    {
        bool Add(char value);
        char Delete();
        bool IsEmpty();
        bool IsFull();
    }
}
