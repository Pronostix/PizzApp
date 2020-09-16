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

            listPizza.Add(new Pizza 
            { 
                Nom = "Végétarienne", 
                Prix = 10, 
                Ingredients = new string[] { "Tomate", "Poivron", "Aubergine", "Olive" } ,
                ImageUrl = "https://cac.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2Fcac.2F2018.2F09.2F25.2Ff0f33831-f80e-45b3-9032-593ada3ace5f.2Ejpeg/750x562/quality/80/crop-from/center/cr/wqkgUGF1bGluYSBKQUtPQklFQy9QUklTTUFQSVggLyBDdWlzaW5lIEFjdHVlbGxl/pizza-vegetarienne.jpeg"
            });
            listPizza.Add(new Pizza 
            { 
                Nom = "Cannibale", 
                Prix = 12, 
                Ingredients = new string[] { "Tomate", "Saucisse", "Merguez", "Viande hachée" },
                ImageUrl = "https://www.lesfoodies.com/_recipeimage/127142/pizza-cannibal-pour-les-gourmands.jpg"
            });
            listPizza.Add(new Pizza 
            { 
                Nom = "Indienne", 
                Prix = 9, 
                Ingredients = new string[] { "Crême fraiche", "Poulet", "Oignon", "Curry" },
                ImageUrl = "https://emporter.pizzapai.fr/media/catalog/product/cache/9/image/9df78eab33525d08d6e5fb8d27136e95/p/i/pizza-indienne.jpg"
            });
            listPizza.Add(new Pizza 
            { 
                Nom = "Texane", 
                Prix = 9, 
                Ingredients = new string[] { "Tomate", "Merguez", "Sauce barbecue", "Fromage" },
                ImageUrl = "https://lh3.googleusercontent.com/proxy/h1zR5iGCTsBN3VstvZf7tNjYctQoXUfD9RKLbt-1PF7tLC7ecDk80f90s0gDMZ19kWSAj1Hl2k2Eod24NnbumUlvY8K9"
            });
            listPizza.Add(new Pizza 
            { 
                Nom = "4 fromages", 
                Prix = 11, 
                Ingredients = new string[] { "Tomate", "Roblochon", "Roquefort", "Gruyère", "Olives", "Parmesan","Brie de Maux", "Mozarella" },
                ImageUrl = "https://static.thiriet.com/data/common_public/gallery_images/site/18756/18774/50361,pizza_pate_fine_4_fromages.jpg"
            });

            PizzasView.ItemsSource = listPizza;
        }
    }
}

