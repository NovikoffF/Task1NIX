using System;
using System.Reflection;
using LibraryNix1;

namespace Task1NIX
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom(@"C:\Users\Yura\source\repos\Library\Library\bin\Debug\netcoreapp3.1\LibraryNix1.dll");
            Console.WriteLine(asm.FullName);

            Type[] types = asm.GetTypes();

            foreach (Type t1 in types)
            {
                Console.WriteLine($"Name: {t1.Name} || Assembly: {t1.Assembly} || Typeinfo: {t1.GetTypeInfo()}");
            }
            Type t = asm.GetType("LibraryNix1.User", true, true);
            object obj = Activator.CreateInstance(t);


            MethodInfo method = t.GetMethod("Solve");
            object result = method.Invoke(obj, new object[] { 2, 2 });
            Console.WriteLine(result);

            Type type2 = typeof(User);
            Console.WriteLine($"Name: {type2.Name}");
            User user = new User("Yura", 23);
            Console.ReadKey();




        }
    }
}
