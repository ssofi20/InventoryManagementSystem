using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Domain;

namespace InventoryManagementSystem.Data.Repositories
{
    internal class ProductRepository
    {
        //Implementation of ProductRepository methods would go here

        public ProductRepository() { }
        public List<Product> GetAllProducts()
        {
            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                dbConnection.setQuery("SELECT * FROM Products");
                
                dbConnection.execRead();
                while (dbConnection.Reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = dbConnection.Reader.GetInt32(0);
                    product.Name = dbConnection.Reader.GetString(1);
                    product.Description = dbConnection.Reader.GetString(2);
                    product.Price = dbConnection.Reader.GetDecimal(3);
                    product.StockQuantity = dbConnection.Reader.GetInt32(4);
                    product.CreatedAt = dbConnection.Reader.GetDateTime(5);
                    product.UpdatedAt = dbConnection.Reader.GetDateTime(6);
                    // Assuming BrandId is an integer foreign key
                    product.BrandId = new Brand { BrandId = dbConnection.Reader.GetInt32(7) };
                    // Categories and Images would require additional queries to populate
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new List<Product>();
        }
    }
}
