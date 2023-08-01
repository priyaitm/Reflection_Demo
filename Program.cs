using System;
using System.Linq;
using System.Reflection;
namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Type s = typeof(string);
            Console.WriteLine(s.Name);                    //String
            Console.WriteLine(s.FullName);                //System.String
            Console.WriteLine(s.BaseType);                 //System.Object
            Console.WriteLine(s.Namespace);                 //System

            Console.WriteLine(s.Assembly);

            Console.WriteLine("\n");




            String Name = "Anuradha";
            Type NameType = Name.GetType();        
            Console.WriteLine("Type is: " + NameType);      // System.String






            // get typeof the Program class and load it to Type variable t     
            Type t = typeof(Program);

            // get Assembly of variable t using the Assembly property
            Console.WriteLine(t.Assembly);


            Console.WriteLine("\n");


   
            Type t1 = typeof(Enumerable);
            Console.WriteLine("Name: " + t1.Name);
            Console.WriteLine("Namespace:" + t1.Namespace);
            Console.WriteLine("Base Type: " + t1.BaseType);

        }

       





        
    }
}
