namespace CoffeeShop.Models
{
    class Cappuccino : Coffee
    {
        public const double PRICE_OF_CAPPUCINO = 1.7;
        public Cappuccino() : base(PRICE_OF_CAPPUCINO)
        {
        }
    }
}
