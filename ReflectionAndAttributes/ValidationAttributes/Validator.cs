using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using ValidationAttributes.Attributes;
using System.Linq;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                var propertyAttributes = property.GetCustomAttributes().Where(a => a is MyValidationAttribute);
                foreach (MyValidationAttribute attribute in propertyAttributes)
                {
                    bool result = attribute.IsValid(property.GetValue(obj));
                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
