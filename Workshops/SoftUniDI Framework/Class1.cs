using SoftUniDI_Framework.Injectors;
using SoftUniDI_Framework.Modules.Contratcs;
using System;

namespace SoftUniDI_Framework
{
    public static class DependencyInjector
    {
        public static Injector CreateInjector(IModule module)
        {
            module.Configure();
            return new Injector(module);
        }
    }
}
