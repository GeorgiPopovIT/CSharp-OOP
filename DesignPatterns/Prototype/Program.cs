using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichMenu menu = new SandwichMenu();

            menu["BLT"] = new Sandwich("Wheat", "Bacon", "Lettuce", "Tomato");
            menu["BT"] = new Sandwich("Wheat",  "", "Lettuce", "Tomato");
            menu["Turkey"] = new Sandwich("Wheat", "Bacon", "", "Tomato");

            Sandwich sandwich1 = menu["BLT"].Clone() as Sandwich;
            Sandwich sandwich2 = menu["BT"].Clone() as Sandwich;
            Sandwich sandwich3 = menu["Turkey"].Clone() as Sandwich;
        }
    }
}
