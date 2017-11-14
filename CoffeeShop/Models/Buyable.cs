using CoffeeShop.Interfaces;

namespace CoffeeShop.Models
{
    public abstract class Buyable : IBuyable, IIngredient
    {
        private double price;

        public Buyable(double price)
        {
            this.Price = price;
        }
        public virtual double Price
        {
            get { return this.price; }
            private set { this.price = value; }
        }
    }
}
