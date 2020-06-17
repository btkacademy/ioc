using IoC.Business.Abstract;
using IoC.Business.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.Business.DependencyResolver.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IXService>().To<XManager2>().InSingletonScope();//Singleton implementasyon

            Bind(typeof(IGenericService<>)).To(typeof(GenericManager2<>));//Generic implementasyon
        }
    }
}
