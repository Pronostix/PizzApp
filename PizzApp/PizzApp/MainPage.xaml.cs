using PizzApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PizzApp
{
    public partial class MainPage : ContentPage
    {
        List<Pizza> listPizza;
        public MainPage()
        {
            InitializeComponent();

            listPizza = new List<Pizza>();

            listPizza.Add(new Pizza { Nom = "Végétarienne", Prix = 10, Ingredient = new string[] { "Tomate", "Poivron", "Aubergine", "Olive" } });
            listPizza.Add(new Pizza { Nom = "Canibalee", Prix = 12, Ingredient = new string[] { "Tomate", "Saucisse", "Merguez", "Viande hachée" } });
            listPizza.Add(new Pizza { Nom = "Indienne", Prix = 9, Ingredient = new string[] { "Crême fraiche", "Poulet", "Oignon", "Curry" } });
            listPizza.Add(new Pizza { Nom = "Texane", Prix = 9, Ingredient = new string[] { "Tomate", "Merguez", "Sauce barbecue", "Fromage" } });
            listPizza.Add(new Pizza { Nom = "4 fromages", Prix = 11, Ingredient = new string[] { "Tomate", "Roblochon", "Roquefort", "Gruyère" } });
        }
    }
}

