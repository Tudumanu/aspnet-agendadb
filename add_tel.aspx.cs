using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Configuration;

public partial class add_tel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // Adiciona registro
        try
        {
            using (OdbcConnection connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLServerConnStr"].ConnectionString))
            {
                connection.Open();
                
                using (OdbcCommand command = new OdbcCommand("INSERT INTO agenda (nome, telefone) VALUES ('" + txtnome.Text + "','" + txttel.Text + "')", connection))
                    command.ExecuteNonQuery();

                connection.Close();
            }

            Response.Redirect("default.aspx");
        }
        catch (Exception ex)
        {
            Response.Write("An error occured: " + ex.Message);
        }  
    }
}