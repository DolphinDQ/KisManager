using KisManager;
using KisManager.Config;
using KisManager.Dal.Kis;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace KisService
{
    class Program
    {
        public static IKisLogin Kis { get; private set; }

        static void Main(string[] args)
        {
#if DEBUG
            Kis = new KisLoginDebug();
#else
            Kis = new KisClsLogin();
#endif
            Console.WriteLine("loading kis lib....");
            if (!Kis.CheckLogin()) return;
            var ip = args?.FirstOrDefault() ?? "http://127.0.0.1:8888/";
            using (var context = new KisContext(Kis.GetConnectionString()))
            {
                Console.Write("try connect kis db...");
                Console.WriteLine(context.ICBOM.Count());
            }
            using (WebApp.Start<Startup>(ip))
            {
                Console.WriteLine("start service at {1} {0}", ip, Kis.AcctName);
                Console.ReadLine();
            }
        }
    }
}
