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
            xService = InstanceFactory.GetInstance<IXService>();
            genericService = InstanceFactory.GetInstance<IGenericService<string>>();

            xService.Method1();
            genericService.GenericMethod("metin");

            Console.ReadKey();
        }
    }
}
