using IoC.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Business.Concrete
{
    public class GenericManager1<T> : IGenericService<string>
    {
        public void GenericMethod(string something)
        {
            Console.WriteLine("GenericManager1.something");
        }
    }
}
