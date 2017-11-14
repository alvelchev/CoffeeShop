namespace CoffeeShop.Models
{
    public class Espresso : Coffee
    {
        public const double PRICE_OF_ESPRESSO = 1.2;
        public Espresso() 
            : base(PRICE_OF_ESPRESSO)
        {
        }
    }
}
