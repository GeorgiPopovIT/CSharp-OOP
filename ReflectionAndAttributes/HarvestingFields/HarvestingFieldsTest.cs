namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            //var search = input.GetType();
            FieldInfo[] fields = typeof(HarvestingFields)
               .GetFields(BindingFlags.Public | BindingFlags.Instance
               | BindingFlags.NonPublic);
            while (input != "HARVEST")
            {
                foreach (var field in fields)
                {
                    var accessModifier = field.Attributes.ToString();
                    if (input == "public")
                    {
                        accessModifier = "public";
                    }
                    else if (input == "private")
                    {
                        accessModifier = "private";
                    }
                    else if (input == "protected")
                    {
                        accessModifier = "protected";
                    }
                    else if (input == "all")
                    {

                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
