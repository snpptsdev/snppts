using Autofac;

namespace Snppts.AutofacModules;

public class SnippetModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterAssemblyTypes(ThisAssembly)
               .Where(t => t.IsAssignableTo<IAmASnippet>())
               .AsImplementedInterfaces()
               .SingleInstance();
    }
}
