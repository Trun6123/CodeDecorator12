using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
   public class OrderDetail
    {
        private String orderID;
        private String productID;
        private double Price;
        private int Quantily;
        public List<OrderDetail> OrderDetails = new List<OrderDetail>();

        public OrderDetail()
        {

        }

        public string OrderID { get => orderID; set => orderID = value; }
        public string ProductID { get => productID; set => productID = value; }
        public double Price1 { get => Price; set => Price = value; }
        public int Quantily1 { get => Quantily; set => Quantily = value; }

        public void Add(string id, string productid, double price, int quantity)
        {

            OrderDetail OrderDetail = new OrderDetail();
            OrderDetail.OrderID = id;
            OrderDetail.ProductID = productid;
            OrderDetail.Price1= price;
            OrderDetail.Quantily1 = quantity;
            OrderDetails.Add(OrderDetail);
           
        }

        public void Edit(string id, string productid, double price, int quantity)
        {

            OrderDetail OrderDetail = new OrderDetail();
            OrderDetail.OrderID = id;
            OrderDetail.ProductID = productid;
            OrderDetail.Price1 = price;
            OrderDetail.Quantily1 = quantity;


            var itemToRemove = OrderDetails.Where(r => r.OrderID == id).Where(x=>x.ProductID==productid).Single();
            OrderDetails.Remove(itemToRemove);
            OrderDetails.Add(OrderDetail);

        }
        public void Delete(string id, string productid)
        {


            var itemToRemove = OrderDetails.Where(r => r.OrderID == id).Where(x => x.ProductID == productid).Single();
            OrderDetails.Remove(itemToRemove);
          


        }

        public void Load()
        {

            OrderDetails.Add(new OrderDetail { OrderID = "1", ProductID = "1", Price = 5, Quantily1 =5,  });
            OrderDetails.Add(new OrderDetail { OrderID = "1", ProductID = "2", Price = 5, Quantily1 =4 });
            OrderDetails.Add(new OrderDetail { OrderID = "2", ProductID = "2", Price = 5, Quantily1 =3 });
        }
    }
}
