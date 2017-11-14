using CoffeeShop.Interfaces;
namespace CoffeeShop.Models
{
    public abstract class Ingredient : Buyable, IIngredient
    {
        public Ingredient(double price)
            : base(price)
        {
        }

        public override string ToString()
        {
            return string.Format("- {0,-20} {1,30}", this.GetType().Name, this.Price);
        }
    }
}
