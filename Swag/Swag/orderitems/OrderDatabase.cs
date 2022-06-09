using SQLite;
using Swag.swg;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Swag.orderitems
{
    public class OrderDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public static OrderDatabase Database = new OrderDatabase(GetDbPath());

        public OrderDatabase(string dbPath )
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Swg1>();
        }
        
        private static string GetDbPath()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            
            
            return Path.Combine(path, "orderitem.db"); ;
        
        }
        
        public async Task<List<Swg1>> GetSwagItemsAsync()
        {
            return await _database.Table<Swg1>().ToListAsync();
        }
        public async Task<int> SaveSwagItemAsync(Swg1 item)
        {
            return await _database.InsertAsync(item);

        }
    }
}
