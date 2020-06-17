using IoC.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Business.Concrete
{
    public class XManager2 : IXService
    {
        public XManager2() { }
        public XManager2(string x)
        {
            Console.WriteLine("loading");
        }
        public void Method1()
        {
            Console.WriteLine("XManager2.Method1");
        }
    }
}
