using SoftUniDI_Framework.Attributes;
using SoftUniDI_Framework.Modules.Contratcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniDI_Framework.Modules
{
    public abstract class AbstractModule : IModule
    {
        private IDictionary<Type, Dictionary<string, Type>> implemention;
        private IDictionary<Type, object> instances;
        public AbstractModule()
        {
            this.implemention = new Dictionary<Type, Dictionary<string, Type>>();
            this.instances = new Dictionary<Type, object>();
        }
        public abstract void Configure();

        protected void CreateMapping<TInter,TImpl>()
        {
            if (!this.implemention.ContainsKey(typeof(TInter)))
            {
                this.implemention[typeof(TInter)] = new Dictionary<string, Type>();
            }
            this.implemention[typeof(TInter)].Add(typeof(TImpl).Name,typeof(TImpl));
        }
        public object GetInstance(Type implementation)
        {
            instances.TryGetValue(implementation,out object value);
            return value;
        }

        public Type GetMapping(Type currentInterface, object attribute)
        {
            var currentImplementation = this.implemention[currentInterface];
            Type type = null;
            if (attribute is Inject)
            {
                if (currentImplementation.Count == 1)
                {
                    type = currentImplementation.Values.First();
                }
                else
                {
                    throw new ArgumentException("No available mapping for class: " + currentInterface.FullName);
                }
            }
            else if (attribute is Named)
            {
                Named named = attribute as Named;

                string dependencyName = named.Name;
                type = currentImplementation[dependencyName];
            }
            return type;
        }

        public void SetInstance(Type implementation, object instance)
        {
            if (!instances.ContainsKey(implementation))
            {
                instances.Add(implementation,instance);
            }
        }
    }
}
