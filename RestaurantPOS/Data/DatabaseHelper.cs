using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace RestaurantPOS.Data
{
    public class DatabaseService : IAsyncDisposable
    {
        private readonly SQLiteAsyncConnection _connection;

        public DatabaseService()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "restaurantpos.db");
            _connection = new SQLiteAsyncConnection(dbPath, SQLite.SQLiteOpenFlags.Create | SQLite.SQLiteOpenFlags.ReadWrite | SQLite.SQLiteOpenFlags.SharedCache);
        }

        public async Task InitializeDatabaseAsync()
        {
            await _connection.CreateTableAsync<MenuCategory>();
            await _connection.CreateTableAsync<MenuItemProduct>();
            await _connection.CreateTableAsync<MenuItemCategoryMapping>();
            await _connection.CreateTableAsync<Order>();
            await _connection.CreateTableAsync<OrderItem>();

            await SeedDataAsync();

            var menuItems = await GetMenuItemsByCategoryAsync(1);
        }

        private async Task SeedDataAsync()
        {
            var categories = await _connection.Table<MenuCategory>().FirstOrDefaultAsync();
            if (categories == null)
            {
                var seedCategories = SeedData.GetMenuCategories();
                await _connection.InsertAllAsync(seedCategories);
            }

            var products = await _connection.Table<MenuItemProduct>().FirstOrDefaultAsync();
            if (products == null)
            {
                var seedMenuItemProducts = SeedData.GetProductMenuItems();
                await _connection.InsertAllAsync(seedMenuItemProducts);
            }

            var categoriesMapping = await _connection.Table<MenuItemCategoryMapping>().FirstOrDefaultAsync();
            if (categoriesMapping == null)
            {
                var seedCategoriesMapping = SeedData.GetMenuItemCategoryMappings();
                await _connection.InsertAllAsync(seedCategoriesMapping);
            }
        }

        public async Task<MenuCategory[]> GetMenuCategoriesAsync() =>
            await _connection.Table<MenuCategory>().ToArrayAsync();

        public async Task<MenuItemProduct[]>GetMenuItemsByCategoryAsync(int categoryId)
        {
            var query = @"
                        SELECT menu.*
                        FROM MenuItemProduct AS menu
                        INNER JOIN MenuItemCategoryMapping AS mapping 
                            ON menu.Id = mapping.MenuItemProductId
                        WHERE mapping.MenuCategoryId = ?
                    ";
            var menuItems = await _connection.QueryAsync<MenuItemProduct>(query, categoryId);
            return [..menuItems];
        }




        public async ValueTask DisposeAsync()
        {
            if (_connection != null)
                await _connection.CloseAsync();
        }
    }
}
