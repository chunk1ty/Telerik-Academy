using Ninject;
using SchoolSystem.Framework.Core;
using SchoolSystem.Framework.Core.Providers;

namespace SchoolSystem.Cli
{
    public class Startup
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel(new SchoolSystemModule());

            Engine engine = kernel.Get<Engine>();

            engine.Start();
        }
    }
}