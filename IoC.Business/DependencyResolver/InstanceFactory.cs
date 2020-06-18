using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
namespace IoC.Business.DependencyResolver
{
    public class InstanceFactory
    {
        static T WithNinject<T>()
        {
            return Ninject.InstanceFactory.GetInstance<T>();
        }

        public static T GetInstance<T>()
        {
            return WithNinject<T>();
        }
    }
}
