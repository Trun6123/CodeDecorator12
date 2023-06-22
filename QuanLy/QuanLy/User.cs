using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
   public class User
    {

        private String userID;
        private String user_name;
        private String password;
        private String fullname;
        private String staff;
        public List<User> Users = new List<User>();

        public string UserID { get => userID; set => userID = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Password { get => password; set => password = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Staff { get => staff; set => staff = value; }

        public User()
        {
         
        }
        public void Add(string id, string name, string pass, string fullname,string staff)
        {

            User User = new User();
            User.UserID = id;
            User.user_name = name;
            User.password = pass;
            User.fullname = fullname;
            User.staff = staff;
            Users.Add(User);
        }

        public void Edit(string id, string name, string pass, string fullname, string staff)
        {

            User User = new User();
            User.UserID = id;
            User.user_name = name;
            User.password = pass;
            User.fullname = fullname;
            User.staff = staff;

            var itemToRemove = Users.Single(r => r.UserID == id);
            Users.Remove(itemToRemove);
            Users.Add(User);

        }
        public void Delete(string id)
        {


            var itemToRemove = Users.Single(r => r.UserID == id);
            Users.Remove(itemToRemove);


        }

        public void Load()
        {

            Users.Add(new User { UserID = "1", User_name = "Lan", Password = "123", Fullname = "Nguyen Tri", Staff="Adm" });
            Users.Add(new User { UserID = "2", User_name = "Tung", Password = "123", Fullname = "Ba Dinh", Staff="User" });
            Users.Add(new User { UserID = "3", User_name = "Chi", Password = "123", Fullname = "Hong Han", Staff = "User" });
        }
    }
}
