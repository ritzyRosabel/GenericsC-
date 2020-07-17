using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //at the point of instantiating your class the generics helps to replace those place holders with a specified type

            MyGenericClass<int> myGeneric = new MyGenericClass<int>(10);
            myGeneric.GenericMethod(20);
            //Parameter type :System.Int32, value:20
            //Field type: System.Int32, Value10
            MyGenericClass<string> myStringGeneric = new MyGenericClass<string>("This is a generic field");
            myStringGeneric.GenericMethod("This is a generic property");
            //Parameter type :System.String, value:This is a generic property
                //Field type: System.String, ValueThis is a generic field
        
            Console.ReadLine();
        }
    }
}
