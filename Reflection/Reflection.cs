using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Reflection
{
    class Reflection
    {
        public static void GetAllProperties(object reflected)
        {
            Type objectType = reflected.GetType();
            PropertyInfo[] properties = objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("Properties : ");
            foreach (var p in properties)
            {
                Console.WriteLine("\t" + p);
            }
        }

        public static void GetAllMethods(object reflected)
        {
            Type objectType = reflected.GetType();
            MethodInfo[] methods = objectType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("Methods : ");
            foreach (var m in methods)
            {
                Console.WriteLine("\t" + m);
            }
        }

        public static void GetAllFields(object reflected)
        {
            Type objectType = reflected.GetType();
            FieldInfo[] fields = objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            Console.WriteLine("Fields : ");
            foreach (var f in fields)
            {
                Console.WriteLine("\t" + f);
            }
        }
    }
}
