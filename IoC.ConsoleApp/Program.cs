using IoC.Business.Abstract;
using IoC.Business.DependencyResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.ConsoleApp
{
    class Program
    {
        static IXService xService;
        static IGenericService<string> genericService;
        static void Main(string[] args)
        {
            NinjectUsage();

            xService.Method1();
            genericService.GenericMethod("metin");

            Console.ReadKey();
        }
        static void NinjectUsage()
        {
            xService = InstanceFactory.GetInstance<IXService>();
            genericService = InstanceFactory.GetInstance<IGenericService<string>>();
        }
    }
}
