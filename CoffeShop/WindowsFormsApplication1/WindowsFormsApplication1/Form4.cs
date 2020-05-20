using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();


            con.ConnectionString = "data source = LAPTOP-L6M55GH9;" +
                                   "database = coffeeshop;" +
                                   "integrated security = SSPI";

            SqlCommand command = new SqlCommand("select * from item", con);
            

            con.Open();

            SqlDataReader DR = command.ExecuteReader();
            


            BindingSource source = new BindingSource();
            source.DataSource = DR;
            


            sellgridview.DataSource = source;
            con.Close();


            SqlConnection con10 = new SqlConnection();


            con10.ConnectionString = "data source = LAPTOP-L6M55GH9;" +
                                   "database = coffeeshop;" +
                                   "integrated security = SSPI";

            SqlCommand command10 = new SqlCommand("select * from placeorder", con10);


            con10.Open();

            SqlDataReader DR10 = command10.ExecuteReader();



            BindingSource source10 = new BindingSource();
            source10.DataSource = DR10;



            selldetailsgridview.DataSource = source10;
            con10.Close();








          



        }

        private void sellgridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = sellgridview.Rows[e.RowIndex];
                itemnumtextbox.Text = row.Cells[0].Value.ToString();
                pricetextbox.Text = row.Cells[2].Value.ToString();
                discounttextbox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void additem_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";

            //Generating SQL Query
            string sql = "INSERT INTO placeorder(datetime,sellerid,itemnumber,quantity,discount,totalbill) VALUES(@param2,@param3,@param4,@param5,@param6,@param7)";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

               

                
                cmd.Parameters.Add("@param2", SqlDbType.VarChar).Value = dateTimePicker1.Text;
                cmd.Parameters.Add("@param3", SqlDbType.VarChar).Value = selleridtextbox.Text;

                
                cmd.Parameters.Add("@param4", SqlDbType.Int).Value = itemnumtextbox.Text;
                cmd.Parameters.Add("@param5", SqlDbType.Int).Value = quantitytextbox.Text;
                cmd.Parameters.Add("@param6", SqlDbType.Int).Value = discounttextbox.Text;


                int price = Convert.ToInt32(pricetextbox.Text);
                int quantity = Convert.ToInt32(quantitytextbox.Text);
                int discount = Convert.ToInt32(discounttextbox.Text);
                int totalbill = (price*quantity)-discount;

                totalbilltextbox.Text = totalbill.ToString();
                
                cmd.Parameters.Add("@param7", SqlDbType.Int).Value = totalbilltextbox.Text;
                


               cmd.CommandType = CommandType.Text;


                  int i = cmd.ExecuteNonQuery();

                con.Close();

                if (i != 0)
                {
                    MessageBox.Show(i + "Data Saved");
                }

                //Disconnect
                con.Close();


                selldetailsgridview.DataSource = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
                selldetailsgridview.Refresh();
                SqlCommand command = new SqlCommand("select * from placeorder", con);


                con.Open();

                SqlDataReader DR = command.ExecuteReader();


                BindingSource source = new BindingSource();
                source.DataSource = DR;


                selldetailsgridview.DataSource = source;
            }

        }

        private void showbillbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();

            



           
        }

        private void selldetailsgridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = selldetailsgridview.Rows[e.RowIndex];
                ordernumbertextbox.Text = row.Cells[0].Value.ToString();
                dateTimePicker1.Text = row.Cells[1].Value.ToString();
                selleridtextbox.Text = row.Cells[2].Value.ToString();
                
                
                itemnumtextbox.Text = row.Cells[3].Value.ToString();
                quantitytextbox.Text = row.Cells[4].Value.ToString();
                discounttextbox.Text = row.Cells[5].Value.ToString();
                totalbilltextbox.Text = row.Cells[6].Value.ToString();
                
            }
        }

        private void deleteitem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //ConnectionString:
            con.ConnectionString = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";

            SqlCommand cmd;



            cmd = new SqlCommand("Delete from placeorder  where orderno=@orderno", con);
            con.Open();
            cmd.Parameters.AddWithValue("@orderno", ordernumbertextbox.Text);
            cmd.Parameters.AddWithValue("@datetime", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@sellerid", selleridtextbox.Text);
            cmd.Parameters.AddWithValue("@itemnumber", itemnumtextbox.Text);
            cmd.Parameters.AddWithValue("@quantity", quantitytextbox.Text);
            cmd.Parameters.AddWithValue("@discount", discounttextbox.Text);
            cmd.Parameters.AddWithValue("@totalbill", totalbilltextbox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Cancel Successfully");
            con.Close();

            selldetailsgridview.DataSource = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
            selldetailsgridview.Refresh();
            SqlCommand command = new SqlCommand("select * from placeorder", con);


            con.Open();

            SqlDataReader DR = command.ExecuteReader();


            BindingSource source = new BindingSource();
            source.DataSource = DR;


            selldetailsgridview.DataSource = source;
        }

        private void finishorder_Click(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    textBox.Clear();
                }
            }
            
        }
    }
}
