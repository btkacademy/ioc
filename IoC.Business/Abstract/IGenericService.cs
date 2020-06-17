using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Business.Abstract
{
    public interface IGenericService<T>
    {
        void GenericMethod(T something);
    }
}
