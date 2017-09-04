using Autofac;
using Autofac.Integration.Mvc;
using System.Linq;
using System.Reflection;
using System.Web.Compilation;
using System.Web.Mvc;


namespace HelloWorlds.MyWorld.Infrastructures
{
    public static class AutofacConfig
    {


        public static void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();
            Assembly[] assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().Where(assembly => assembly.FullName.StartsWith("HelloWorlds") || assembly.FullName.StartsWith("IndividualWorlds")).ToArray();
            builder.RegisterAssemblyModules(assemblies);
            builder.RegisterControllers(assemblies);
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}