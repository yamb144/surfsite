using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class SignIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request.HttpMethod == "POST")
        {
            string email = Request["email"];
            string password = Request["password"];
            string sql = "Select * from users where email='" + email + "' and password='" + password + "';";
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\mairav\\Documents\\Visual Studio 2017\\WebSites\\WebSite1\\App_Data\\Database.mdf; Integrated Security = True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter tableAdapter = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            tableAdapter.Fill(dt);
            if (dt.Rows.Count>0)
            {
                Session["username"] = dt.Rows[0]["username"];
                Session["name"] = dt.Rows[0]["name"];
                Session["password"] = dt.Rows[0]["password"];
                Session["phone"] = dt.Rows[0]["phone"];
                Session["email"] = dt.Rows[0]["email"];
                Session["date"] = dt.Rows[0]["date"];
                Response.Redirect("HomePageUser.aspx");



            }
        }
        
    }
    }
