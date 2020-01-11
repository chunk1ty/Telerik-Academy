using Dealership.Engine;
using Dealership.Factories;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using System.IO;
using System.Reflection;

namespace Dealership
{
    public class NinjectConfigurationModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x =>
            {
                x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .SelectAllClasses()
                .BindDefaultInterface();
            });

            Bind<IDealershipFactory>().ToFactory().InSingletonScope();
            Kernel.Bind<IEngine>().To<DealershipEngine>().InSingletonScope();
        }
    }
}
