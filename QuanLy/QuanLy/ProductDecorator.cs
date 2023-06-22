using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
     public abstract class ProductDecorator : IProduct
    {

        protected IProduct Iproduct;
        private List<Product> products=new List<Product>();
        public List<Product> Products { get => products; set => products=value; }


        public abstract void productDecorator(IProduct product);


        public abstract void productDecorator(IProduct product,string id, double voucher);


        public  DataTable dataTable = new DataTable();
        public void  DisplayInfor()
        {

            dataTable.Columns.Add("ProductID", typeof(String));
            dataTable.Columns.Add("ProductName", typeof(String));
            dataTable.Columns.Add("Price", typeof(String));
            dataTable.Columns.Add("Vodel", typeof(String));
            dataTable.Columns.Add("Description", typeof(String));
            foreach (var i in products)
            {
                dataTable.Rows.Add(i.ProductID, i.ProductName, i.Price, i.Vodel, i.Description);
            }
        }

      
    }
}
