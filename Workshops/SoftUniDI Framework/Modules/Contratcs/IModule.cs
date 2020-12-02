using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniDI_Framework.Modules.Contratcs
{
    public interface IModule
    {
        void Configure();
        Type GetMapping(Type currentInterface, object attribute);
        object GetInstance(Type implementation);
        void SetInstance(Type implementation, object instance);
    }
}
