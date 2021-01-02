using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12_sem3_sharp
{
    interface ICloneable
    {
        object DeepClone();
        object ShallowClone();
    }
}
