using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Domain;

namespace InventoryManagementSystem.Data.Repositories
{
    public class ProductRepository
    {
        //Implementation of ProductRepository methods would go here

        public ProductRepository() { }
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                DatabaseConnection dbConnection = new DatabaseConnection();
                dbConnection.setQuery("SELECT ProductId, P.Name, Description, Price, Stock, B.BrandId, B.Name, P.CreatedAt, UpdatedAt\r\nFROM PRODUCTS P, BRANDS B\r\nWHERE P.BrandId = B.BrandId");
                
                dbConnection.execRead();
                while (dbConnection.Reader.Read())
                {
                    Product product = new Product();
                    product.ProductId = Convert.ToInt32(dbConnection.Reader["ProductId"]);
                    product.Name = dbConnection.Reader["Name"].ToString();
                    product.Description = dbConnection.Reader["Description"].ToString();
                    product.Price = Convert.ToDecimal(dbConnection.Reader["Price"]);
                    product.StockQuantity = Convert.ToInt32(dbConnection.Reader["Stock"]);
                    Brand brand = new Brand();
                    brand.BrandId = Convert.ToInt32(dbConnection.Reader["BrandId"]);
                    brand.Name = dbConnection.Reader["Name"].ToString();

                    products.Add(product);
                }
                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
