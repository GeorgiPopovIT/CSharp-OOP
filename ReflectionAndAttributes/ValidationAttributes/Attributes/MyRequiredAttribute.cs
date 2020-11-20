using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Entity;

namespace ValidationAttributes.Attributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            return obj != null;
        }
    }
}
