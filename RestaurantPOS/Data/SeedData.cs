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
                },
                new MenuCategory
                {
                    Id = 5,
                    Name = "Icecream",
                    Icon = "ice_cream.png"
                }
            };
        }

        public static List<MenuItemProduct> GetProductMenuItems()
        {
            return new List<MenuItemProduct>
            {
                new MenuItemProduct
                {
                    Id = 1,
                    Name = "Classic Burger",
                    Icon = "burger.png",
                    Description = "Juicy beef patty with lettuce, tomato, and cheese.",
                    Price = 8.99m
                },
                new MenuItemProduct
                {
                    Id = 2,
                    Name = "Veggie Burger",
                    Icon = "burger.png",
                    Description = "Grilled veggie patty with fresh greens and avocado.",
                    Price = 7.99m
                },
                new MenuItemProduct
                {
                    Id = 3,
                    Name = "Margherita Pizza",
                    Icon = "pizza.png",
                    Description = "Classic pizza with tomato, mozzarella, and basil.",
                    Price = 10.99m
                },
                new MenuItemProduct
                {
                    Id = 4,
                    Name = "Pepperoni Pizza",
                    Icon = "pizza.png",
                    Description = "Pepperoni, mozzarella, and tomato sauce.",
                    Price = 12.49m
                },
                new MenuItemProduct
                {
                    Id = 5,
                    Name = "Caesar Salad",
                    Icon = "salad.png",
                    Description = "Romaine lettuce, parmesan, croutons, and Caesar dressing.",
                    Price = 6.99m
                },
                new MenuItemProduct
                {
                    Id = 6,
                    Name = "Greek Salad",
                    Icon = "salad.png",
                    Description = "Tomatoes, cucumber, olives, feta cheese, and olive oil.",
                    Price = 7.49m
                },
                new MenuItemProduct
                {
                    Id = 7,
                    Name = "Cola",
                    Icon = "drink.png",
                    Description = "Chilled classic cola beverage.",
                    Price = 2.49m
                },
                new MenuItemProduct
                {
                    Id = 8,
                    Name = "Orange Juice",
                    Icon = "drink.png",
                    Description = "Freshly squeezed orange juice.",
                    Price = 3.49m
                }

                ,
                new MenuItemProduct
                {
                    Id = 8,
                    Name = "Orange Juice",
                    Icon = "drink.png",
                    Description = "Freshly squeezed orange juice.",
                    Price = 3.49m
                }
                ,
                new MenuItemProduct
                {
                    Id = 8,
                    Name = "Orange Juice",
                    Icon = "drink.png",
                    Description = "Freshly squeezed orange juice.",
                    Price = 3.49m
                }
                ,
                new MenuItemProduct
                {
                    Id = 8,
                    Name = "Orange Juice",
                    Icon = "drink.png",
                    Description = "Freshly squeezed orange juice.",
                    Price = 3.49m
                }
                ,
                new MenuItemProduct
                {
                    Id = 8,
                    Name = "Orange Juice",
                    Icon = "drink.png",
                    Description = "Freshly squeezed orange juice.",
                    Price = 3.49m
                }
                ,
                new MenuItemProduct
                {
                    Id = 8,
                    Name = "Orange Juice",
                    Icon = "drink.png",
                    Description = "Freshly squeezed orange juice.",
                    Price = 3.49m
                }
                ,
                new MenuItemProduct
                {
                    Id = 8,
                    Name = "Orange Juice",
                    Icon = "drink.png",
                    Description = "Freshly squeezed orange juice.",
                    Price = 3.49m
                }
                ,
                new MenuItemProduct
                {
                    Id = 8,
                    Name = "Orange Juice",
                    Icon = "drink.png",
                    Description = "Freshly squeezed orange juice.",
                    Price = 3.49m
                }
                ,
                new MenuItemProduct
                {
                    Id = 9,
                    Name = "Pasta",
                    Icon = "pasta.png",
                    Description = "Pasta.",
                    Price = 1.49m
                }
                ,
                new MenuItemProduct
                {
                    Id = 10,
                    Name = "Donut",
                    Icon = "donut.png",
                    Description = "Donut",
                    Price = 1.29m
                }
                ,
                new MenuItemProduct
                {
                    Id = 11,
                    Name = "Hamburger",
                    Icon = "hamburger.png",
                    Description = "Hamburger",
                    Price = 2.49m
                }
                ,
                new MenuItemProduct
                {
                    Id = 12,
                    Name = "Cupcake",
                    Icon = "cupcake.png",
                    Description = "Cupcake",
                    Price = 1.10m
                }
            };
        }

        public static List<MenuItemCategoryMapping>GetMenuItemCategoryMappings()
        {
            return new List<MenuItemCategoryMapping>
            {
                new MenuItemCategoryMapping { Id = 1, MenuItemProductId = 1, MenuCategoryId = 1 },
                new MenuItemCategoryMapping { Id = 2, MenuItemProductId = 2, MenuCategoryId = 1 },
                new MenuItemCategoryMapping { Id = 3, MenuItemProductId = 3, MenuCategoryId = 2 },
                new MenuItemCategoryMapping { Id = 4, MenuItemProductId = 4, MenuCategoryId = 2 },
                new MenuItemCategoryMapping { Id = 5, MenuItemProductId = 5, MenuCategoryId = 3 },
                new MenuItemCategoryMapping { Id = 6, MenuItemProductId = 6, MenuCategoryId = 3 },
                new MenuItemCategoryMapping { Id = 7, MenuItemProductId = 7, MenuCategoryId = 4 },
                new MenuItemCategoryMapping { Id = 8, MenuItemProductId = 8, MenuCategoryId = 4 },
                new MenuItemCategoryMapping { Id = 9, MenuItemProductId = 9, MenuCategoryId = 1 },
                new MenuItemCategoryMapping { Id = 10, MenuItemProductId = 10, MenuCategoryId = 1 },
                new MenuItemCategoryMapping { Id = 11, MenuItemProductId = 11, MenuCategoryId = 1 },
                new MenuItemCategoryMapping { Id = 12, MenuItemProductId = 12, MenuCategoryId = 5 }
            };
        }
    }
}
