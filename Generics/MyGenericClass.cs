using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyGenericClass<T>//the place holder ca be of any value
    {
        private T genericField;

        public MyGenericClass(T values)
        {
            genericField = values;
        }
    }
}
