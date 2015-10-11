using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;
using System.Configuration;

public partial class atualiza_tel : System.Web.UI.Page
{
    int id = 0;
    protected void Page_Load(object sender, EventArgs e)
    {        
        // recupera parametro
        id = Int32.Parse(Request.QueryString["identificador"]);

        //verifica se ja inicializou campo, evita alterar valor setado pelo usuario
        if (txtnome.Text != "")
            return;

        try
        {
            using (OdbcConnection connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLServerConnStr"].ConnectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand("SELECT * FROM agenda WHERE id=" + id, connection))
                using (OdbcDataReader dr = command.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        txtnome.Text = dr["nome"].ToString();
                        txttel.Text = dr["telefone"].ToString();
                    }
                    dr.Close();
                }
                connection.Close();
            }
        }
        catch (Exception ex)
        {
            Response.Write("An error occured: " + ex.Message);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            using (OdbcConnection connection = new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLServerConnStr"].ConnectionString))
            {
                connection.Open();

                using (OdbcCommand command = new OdbcCommand("UPDATE agenda SET nome='" + txtnome.Text + "' , telefone='" + txttel.Text + "' WHERE id=" + id, connection))
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