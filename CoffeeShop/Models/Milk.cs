namespace CoffeeShop.Models
{
    public class Milk : Ingredient
    {
        private const double PriceOfMilk = 0.4;

        public Milk() 
            : base(PriceOfMilk)
        {
        }
    }
}
