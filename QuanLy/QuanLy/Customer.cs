using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
    public class Customer
    {

        public Customer()

        {
           
        }
        private String customerID;
        private String customer_name;
        private int phone;
        private String adress;
        public List<Customer> Customers =new List<Customer>();
        public string CustomerID { get => customerID; set => customerID = value; }
        public string Customer_name { get => customer_name; set => customer_name = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Adress { get => adress; set => adress = value; }

        public void Add(string id, string name,int phone, string address)
        {

            Customer customer = new Customer();
            customer.CustomerID = id;
            customer.Customer_name = name;
            customer.Phone = phone;
            customer.Adress = address;

            Customers.Add(customer);
        }

        public void Edit(string id, string name, int phone, string address)
        {

            Customer customer = new Customer();
            customer.CustomerID = id;
            customer.Customer_name = name;
            customer.Phone = phone;
            customer.Adress = address;

            var itemToRemove = Customers.Single(r => r.CustomerID == id);
            Customers.Remove(itemToRemove);
            Customers.Add(customer);

        }
        public void Delete(string id)
        {


            var itemToRemove = Customers.Single(r => r.CustomerID == id);
            Customers.Remove(itemToRemove);


        }


        public void Load()
        {

            Customers.Add(new Customer {CustomerID="1",Customer_name="Nguyen Van A",Phone=0935812310,Adress="Nguyen Tri Phuong" });
            Customers.Add(new Customer { CustomerID = "2", Customer_name = "Tran Thi B", Phone = 093596320, Adress = "Ba Dinh" });
            Customers.Add(new Customer { CustomerID = "3", Customer_name = "Tran Viet X", Phone = 0935812310, Adress = "Hang Quat" });
         
        }
    }
}
