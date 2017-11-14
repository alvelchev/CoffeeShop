using CoffeeShop.Interfaces;
using CoffeeShop.Models;
namespace CoffeeShop
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Resources;
    using System.Text;
    using System.Windows.Forms;

    public partial class CoffeeShop : Form
    {
        private List<Coffee> coffes;
        public CoffeeShop()
        {
            coffes = new List<Coffee>();
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            foreach (Coffee c in coffes.ToList())
            {
                this.coffes.Remove(c);
                
            }
        }

        private void ButtonEsspresso_Click(object sender, EventArgs e)
        {
            Espresso esspresso = new Espresso();
            this.coffes.Add(esspresso);
            ShowInformation(this, null);
            listView1.Items.Add(esspresso.ToString());
        }

        private void ButtonCappuchino_Click(object sender, EventArgs e)
        {
            Cappuccino cap = new Cappuccino();
            this.coffes.Add(cap);
            ShowInformation(this, null);
            listView1.Items.Add(cap.ToString());
        }

        private void ButtonDecaffeinedCoffee_Click(object sender, EventArgs e)
        {
            Decaffeinated uncoffee = new Decaffeinated();
            this.coffes.Add(uncoffee);
            ShowInformation(this, null);
            listView1.Items.Add(uncoffee.ToString());
        }

        private void ShowInformation(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Bill:");
            foreach (Coffee coffee in coffes)
            {
                builder.AppendLine(coffee.ToString());
            }
            builder.AppendLine();
            TotalBill.Text = (string.Format("Total bill: {0}", coffes.Sum(x => x.GetTotalPrice)));
            Result.Text = builder.ToString();
        }

        private void AddIngredient(IIngredient ingredient)
        {
            if (this.coffes.Count > 0)
            {
                this.coffes[coffes.Count - 1].AddIngridient(ingredient);
            }
        }

        private void ApplyLanguage(CultureInfo ci, ResourceManager rm)
        {
            BtnCapuchino.Text = rm.GetString("Cappucino", ci);
            BtnCinnamon.Text = rm.GetString("Cinnamon", ci);
            BtnEspresso.Text = rm.GetString("Espresso", ci);
            BtnDecaffeinedCoffee.Text = rm.GetString("DecaffeinedCoffee", ci);
            BtnMilk.Text = rm.GetString("Milk", ci);
            BtnSugar.Text = rm.GetString("Sugar", ci);
            BtnBack.Text = rm.GetString("Clear", ci);
            Bulgarian.Text = rm.GetString("LanguageBulgarian", ci);
            Result.Text = rm.GetString("Bill", ci);
            CoffeeShop.ActiveForm.Text = rm.GetString("CoffeeShop", ci);
            BtnBuy.Text = rm.GetString("Buy", ci);
            ShowInformation(this, null);
        }

        private void ButtonBulgarianLanguage_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.Load("CoffeeShop");
            ApplyLanguage(new CultureInfo("bg-BG"), new ResourceManager("CoffeeShop.Languages.Languages", a));
        }

        private void ButtonEnglishLanguage_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.Load("CoffeeShop");
            ApplyLanguage(new CultureInfo("en-US"), new ResourceManager("CoffeeShop.Languages.Lang", a));
        }

        private void ButtonBuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to order?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                this.Show();
            }
            else
            {
                MessageBox.Show("Succesful Order!");
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var btn = (Button)sender;
                switch (btn.Name)
                {
                    case "BtnMilk":
                        //AddIngredient(new Milk());
                        //listView1.Items.Add(new Milk().ToString());
                        listView1.Items.Insert(listView1.SelectedItems[0].Index + 1, new Milk().ToString());
                        break;
                    case "BtnSugar":
                        //AddIngredient(new Sugar());
                        //listView1.Items.Add(new Sugar().ToString());
                        listView1.Items.Insert(listView1.SelectedItems[0].Index + 1, new Sugar().ToString());
                        break;
                    case "BtnCinnamon":
                        //AddIngredient(new Cinnamon());
                        //listView1.Items.Add(new Cinnamon().ToString());
                        listView1.Items.Insert(listView1.SelectedItems[0].Index + 1, new Cinnamon().ToString());
                        break;
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("One of the coffee types in the order should be selected in order to add ingredient to it!");
            }
            ShowInformation(this, null);
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {
            Result.SelectionStart = Result.Text.Length;
            Result.ScrollToCaret();
        }
    }
}
