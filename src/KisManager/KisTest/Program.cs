using System;
namespace KisTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var type = Type.GetTypeFromProgID("K3Login.ClsLogin");
            Console.WriteLine("type = " + type);
            object a = Activator.CreateInstance(type);
            Console.WriteLine("a = " + a);
            try
            {
                var b = type.InvokeMember("[DispID=1610809350]", System.Reflection.BindingFlags.InvokeMethod, null, a, null);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine("err:"+e);
            }
            Console.Read();
        }
    }
}
