using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class SignUpPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.HttpMethod=="POST")
        {
            string username = Request.Form["username"];
            string name = Request["name"];
            string password = Request["password"];
            string phone = Request["phone"];
            string email = Request.Form["mail"];
            string date = Request["date"];
            string sql = "INSERT INTO Users VALUES('" + username + "', '" + name + "', '" + password + "', '" + phone + "', '" + email + "', '" + date + "')";

            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\mairav\\Documents\\Visual Studio 2017\\WebSites\\WebSite1\\App_Data\\Database.mdf; Integrated Security = True;";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            connect.Close();
            
        }
    }
}