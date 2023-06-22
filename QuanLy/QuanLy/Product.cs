using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
   public class Product: IProduct
    {
        private String productID;
        private String productName;
        private double price;
        private String description;
        private double vodel;
        public List<Product> products =new List<Product>();
        public Product()
        {

        }

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public double Vodel { get => vodel; set => vodel = value; }
        public List<Product> Products { get => products; set => products = value; }

        public void DisplayInfor()
        {
           
        }
        public void Add(string id, string name, double price, string description)
        {

            Product Product = new Product();
            Product.ProductID = id;
            Product.productName = name;
            Product.Price = price;
            Product.Description = description;
            Product.Vodel = 0;
            Products.Add(Product);
        }

        public void Edit(string id, string name, double price, string description)
        {

            Product Product = new Product();
            Product.ProductID = id;
            Product.productName = name;
            Product.Price = price;
            Product.Description = description;
            Product.Vodel = 0;

            var itemToRemove = Products.Single(r => r.ProductID == id);
            Products.Remove(itemToRemove);
            Products.Add(Product);

        }
        public void Delete(string id)
        {


            var itemToRemove = Products.Single(r => r.ProductID == id);
            Products.Remove(itemToRemove);


        }

        public void Load()
        {

            Products.Add(new Product { ProductID = "1", ProductName = "SamSUng", Price = 5, Description = " ", Vodel = 5 });
            Products.Add(new Product { ProductID = "2", ProductName = "Nokia", price = 5, Description = " ", Vodel = 5 });
            Products.Add(new Product { ProductID = "3", ProductName = "Motorola", price = 5, Description = " ", Vodel = 5 });
        }

        public IProduct ManufactureProduct()
        {
            throw new NotImplementedException();
        }
    }
}
