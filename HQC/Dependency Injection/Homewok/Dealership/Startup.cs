using Dealership.Engine;
using Ninject;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel(new NinjectConfigurationModule());

            IEngine engine = kernel.Get<IEngine>();

            engine.Start();
        }
    }
}
