using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
   public class Order
    {
        private String orderID;
        private String userID;
        private String customerID;
        private double totalcost;
        private DateTime dateCreate;
        private String status;
        public List<Order> Orders = new List<Order>();
        public Order()
        {

        }

        public string OrderID { get => orderID; set => orderID = value; }
        public string UserID { get => userID; set => userID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public double Totalcost { get => totalcost; set => totalcost = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public string Status { get => status; set => status = value; }

        public void Add(string id, string UserID,string CustomerID, double Totalcost, DateTime DateCreate, string status)
        {

            Order Order = new Order();
            Order.OrderID = id;
            Order.UserID = UserID;
            Order.CustomerID = CustomerID;
            Order.Totalcost = Totalcost;
            Order.DateCreate = DateCreate;
            Order.Status = Status;
            Orders.Add(Order);

        }

        public void Edit(string id, string UserID, string CustomerID, double Totalcost, DateTime DateCreate, string status)
        {

            Order Order = new Order();
            Order.OrderID = id;
            Order.UserID = UserID;
            Order.CustomerID = CustomerID;
            Order.Totalcost = Totalcost;
            Order.DateCreate = DateCreate;
            Order.Status = Status;


            var itemToRemove = Orders.Where(r => r.OrderID == id).Single();
            Orders.Remove(itemToRemove);
            Orders.Add(Order);

        }
        public void Delete(string id, string UserID, string CustomerID)
        {


            var itemToRemove = Orders.Where(r => r.OrderID == id).Single();
            Orders.Remove(itemToRemove);



        }

        public void Load()
        {

            Orders.Add(new Order { OrderID = "1",  UserID = "1", CustomerID = "1", Totalcost = 10,DateCreate=DateTime.Parse("11/12/2023"), Status="CK" });
         
            Orders.Add(new Order { OrderID = "2", UserID = "2", CustomerID = "3", Totalcost = 5, DateCreate = DateTime.Parse("11/12/2023"), Status="Nợ" });
        }
    }
}
