using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Extensions.Interception.Infrastructure.Language;
using Ninject.Modules;
using SchoolSystem.Cli.Configuration;
using SchoolSystem.Cli.Interceptors;
using SchoolSystem.Framework.Core;
using SchoolSystem.Framework.Core.Commands;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Core.Contracts;
using SchoolSystem.Framework.Core.Providers;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Repository;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SchoolSystem.Cli
{
    public class SchoolSystemModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x =>
            {
                x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .SelectAllClasses()
                .Where(type => type != typeof(StudentRepository))
                .BindDefaultInterface();
            });

            Kernel.Bind<Engine>().ToSelf().InSingletonScope();

            Bind<CreateStudentCommand>().ToSelf().InSingletonScope();
            Bind<CreateTeacherCommand>().ToSelf().InSingletonScope();
            Bind<RemoveStudentCommand>().ToSelf().InSingletonScope();
            Bind<RemoveTeacherCommand>().ToSelf().InSingletonScope();
            Bind<StudentListMarksCommand>().ToSelf().InSingletonScope();
            Bind<TeacherAddMarkCommand>().ToSelf().InSingletonScope();

            Kernel.Bind<IReader>().To<ConsoleReaderProvider>().InSingletonScope();
            Kernel.Bind<IWriter>().To<ConsoleWriterProvider>().InSingletonScope();
            Kernel.Bind<IParser>().To<CommandParserProvider>().InSingletonScope();

            // ToFactory is an external Ninject package (Ninject.Extensions.Factory)
            // ToFactory() - Ninject create new instance of Student
            var studentFactoryBinding = Kernel.Bind<IStudentFactory>().ToFactory().InSingletonScope();
            var commandFactoryBinding = Kernel.Bind<ICommandFactory>().ToFactory().InSingletonScope();            
            var markFactoryBinding = Kernel.Bind<IMarkFactory>().ToFactory().InSingletonScope();
            Kernel.Bind<ITeacherFactory>().ToFactory().InSingletonScope();

            IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();

            if (configurationProvider.IsTestEnvironment)
            {
                // Ninject.Extensions.Interception external package for Interceptor
                commandFactoryBinding.Intercept().With<StopwatchInterceptor>();
                studentFactoryBinding.Intercept().With<StopwatchInterceptor>();
                markFactoryBinding.Intercept().With<StopwatchInterceptor>();
            }

            Kernel.Bind<IStudentRepository>().To<StudentRepository>().InSingletonScope();
            Kernel.Bind<ITeacherRepository>().To<TeacherRepository>().InSingletonScope();

            // ToMethod() -> implement GetCommand method (from ICommand interface)
            Kernel.Bind<ICommand>().ToMethod(context => 
            {
                Type commandType = (Type)context.Parameters.Single().GetValue(context, null);
                return (ICommand)context.Kernel.Get(commandType);
            }).NamedLikeFactoryMethod((ICommandFactory commandFactory) => commandFactory.GetCommand(null));
        }
    }
}