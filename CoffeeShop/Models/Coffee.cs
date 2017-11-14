using CoffeeShop.Interfaces;
namespace CoffeeShop.Models
{ 
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public abstract class Coffee : Buyable, ICoffee
    {
        private List<IIngredient> ingredients;

        public Coffee(double price)
            : base(price)
        {
            this.ingredients = new List<IIngredient>();
        }

        public override double Price
        {
            get { return base.Price; }
        }

        public double GetTotalPrice
        {
            get { return base.Price + this.ingredients.Sum(x => x.Price); }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("{0,-20} {1,25}", this.GetType().Name, this.Price));
            foreach (Ingredient ingredient in ingredients)
            {
                builder.AppendLine(ingredient.ToString());
            }

            return builder.ToString();
        }

        public void AddIngridient(IIngredient ingridien)
        {
            this.ingredients.Add(ingridien);
        }
    }
}
