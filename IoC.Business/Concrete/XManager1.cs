using IoC.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Business.Concrete
{
    public class XManager1 : IXService
    {
        public void Method1()
        {
            Console.WriteLine("Xmanager1.Method1");
        }
    }
}
