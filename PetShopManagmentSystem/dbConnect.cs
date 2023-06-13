using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PetShopManagmentSystem
{
    class dbConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;

        
        public string connection()
        {
            con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Prog\github\PetShopManagmentSystem\PetShopManagmentSystem\dbPetShop.mdf;Integrated Security=True;Connect Timeout = 30";
            return con;
        }
    }
}
