using DecoradorCafesGluGlu.Components;
using DecoradorCafesGluGlu.Components.Abstraction;

namespace DecoradorCafesGluGlu.Components
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99;
        }
    }
}
