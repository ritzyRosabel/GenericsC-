using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MyGenericClass<T>//the place holder ca be of any value
    {
        private readonly T genericField;

        public MyGenericClass(T values)
        {
            genericField = values;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type :{0}, value:{1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Field type: {0}, Value{1}", typeof(T), genericField);
            return genericField;
        }
    }
}
