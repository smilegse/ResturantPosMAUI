using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPOS.Data
{
    public static class SeedData
    {
        public static List<MenuCategory> GetMenuCategories()
        {
            return new List<MenuCategory>
            {
                new MenuCategory
                {
                    Id = 1,
                    Name = "Burgers",
                    Icon = "burger.png" // Ensure this image exists in Resources/Images
                },
                new MenuCategory
                {
                    Id = 2,
                    Name = "Pizzas",
                    Icon = "pizza.png"
                },
                new MenuCategory
                {
                    Id = 3,
                    Name = "Salads",
                    Icon = "salad.png"
                },
                new MenuCategory
                {
                    Id = 4,
                    Name = "Drinks",
                    Icon = "drink.png"
                }
            };
        }
    }
}
