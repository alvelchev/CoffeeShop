namespace CoffeeShop.Models
{
    public class Decaffeinated : Coffee
    {
        public const double PRICE_OF_UNCOFFENE = 1.5;
        public Decaffeinated() : base(PRICE_OF_UNCOFFENE)
        {
        }
    }
}
