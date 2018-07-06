using KisManager.Config;
using System;
using System.Linq.Expressions;
namespace KisTest
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                PrintKisInfo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.Read();
        }

        static void PrintKisInfo()
        {
            var login = new KisClsLogin();
            try
            {
                if (login.CheckLogin())
                {
                    Write(() => login.IsDemo);
                    Write(() => login.IsIndustry);
                    Write(() => login.PropsString);
                    Write(() => login.ServerMgr);
                    Write(() => login.UserName);
                    Write(() => login.AcctName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Write<T>(Expression<Func<T>> exp)
        {
            Console.WriteLine("{0}=>{1}", ((MemberExpression)exp.Body).Member.Name, exp.Compile()());
        }
    }
}
