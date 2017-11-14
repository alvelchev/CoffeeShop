namespace CoffeeShop.Models
{
    public class Sugar : Ingredient
    {
        private const double PriceOfSugar = 0.05;
        public Sugar() : base(PriceOfSugar)
        {
        }
    }
}
