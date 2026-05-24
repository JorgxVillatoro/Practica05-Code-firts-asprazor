using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Estudiantes_Jorge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MINEDUCYT\Documents\Proyectos arcides 2026\Estudiantes-Jorge\Empleados-jorge\Estudiantes-Jorge.accdb");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into Estudiantes(Nombre,Genero,Email,Ciudad) values('" + TextBox2.Text + "','" + RadioButtonList1.Text + "','" + TextBox3.Text + "','" + TextBox3.Text + "')", conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Datos guardados')", true);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("update Estudiantes set Nombre='" + TextBox2.Text + "',Genero='" + RadioButtonList1.Text + "',Email='" + TextBox3.Text + "',Ciudad='" + TextBox4.Text + "' where Id=" + TextBox1.Text + "", conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Student updated')", true);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("delete from Estudiantes where Id=" + TextBox1.Text + "", conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Student delete')", true);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Estudiantes", conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {

            bool temp = false;

            conexion.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Estudiantes where Id=" + TextBox1.Text + "", conexion);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TextBox2.Text = dr.GetString(1);
                RadioButtonList1.Text = dr.GetString(2);
                TextBox3.Text = dr.GetString(3);
                TextBox3.Text = dr.GetString(4);

                temp = true;
            }

            if (temp == false)
                Label1.Text = "Student not found";

            conexion.Close();

        }
    }
}