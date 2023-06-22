using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
    class DeliveryDecorator : ProductDecorator
    {
        public override void productDecorator(IProduct product)
        {

        }

        public override void productDecorator(IProduct product, string id, double Delivery)
        {

            var i = product.Products.SingleOrDefault(x => x.ProductID == id);
            Product Product = new Product();
            Product.ProductID = product.Products.SingleOrDefault(x => x.ProductID == id).ProductID.ToString();
            Product.ProductName = i.ProductName.ToString();
            Product.Price = i.Price;
            Product.Description = i.Description;
            Product.Vodel = Delivery;
            product.Products.Remove(i);
            product.Products.Add(Product);
        }
    }
}
