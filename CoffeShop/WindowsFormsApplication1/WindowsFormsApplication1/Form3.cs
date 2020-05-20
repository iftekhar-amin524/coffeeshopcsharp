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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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


            itemgridview.DataSource = source;


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source =LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
            //Generating SQL Query
            string sql = "INSERT INTO item(itemname,price,discount) VALUES(@param1,@param2,@param3)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();
                if (itemname.Text != "" && price.Text != "" && discount.Text != "")
                {

                    cmd.Parameters.Add("@param1", SqlDbType.VarChar).Value = itemname.Text;
                    cmd.Parameters.Add("@param2", SqlDbType.Int).Value = price.Text;
                    cmd.Parameters.Add("@param3", SqlDbType.Int).Value = discount.Text;



                    cmd.CommandType = CommandType.Text;


                    int i = cmd.ExecuteNonQuery();

                    con.Close();

                    if (i != 0)
                    {
                        MessageBox.Show(i + "Data Saved");
                    }

                    //Disconnect
                    con.Close();

                    itemgridview.DataSource = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
                    itemgridview.Refresh();
                    SqlCommand command = new SqlCommand("select * from item", con);


                    con.Open();

                    SqlDataReader DR = command.ExecuteReader();


                    BindingSource source = new BindingSource();
                    source.DataSource = DR;


                    itemgridview.DataSource = source;

                }
             


                
                else
                {
                    MessageBox.Show("Please fill up fields");
                } 

            }


        }

        private void itemgridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = itemgridview.Rows[e.RowIndex];
                itemnumber.Text = row.Cells[0].Value.ToString();
                itemname.Text = row.Cells[1].Value.ToString();
                price.Text = row.Cells[2].Value.ToString();
                discount.Text = row.Cells[3].Value.ToString();
            }
        }

        private void updateitem_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
            SqlCommand cmd;


            if (itemname.Text != "" && price.Text != "" && discount.Text != "")
            {
                cmd = new SqlCommand("update item set itemname=@itemname,price=@price,discount=@discount where itemnumber=@itemnumber", con);
                con.Open();
                cmd.Parameters.AddWithValue("@itemnumber", itemnumber.Text);
                cmd.Parameters.AddWithValue("@itemname", itemname.Text);
                cmd.Parameters.AddWithValue("@price", price.Text);
                cmd.Parameters.AddWithValue("@discount", discount.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();

                itemgridview.DataSource = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
                itemgridview.Refresh();
                SqlCommand command = new SqlCommand("select * from item", con);


                con.Open();

                SqlDataReader DR = command.ExecuteReader();


                BindingSource source = new BindingSource();
                source.DataSource = DR;


                itemgridview.DataSource = source;


                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }  
        }

        private void deleteitem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //ConnectionString:
            con.ConnectionString = "data source =LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";

            SqlCommand cmd;



            cmd = new SqlCommand("Delete from item  where itemnumber=@itemnumber", con);
            con.Open();
            cmd.Parameters.AddWithValue("@itemnumber", itemnumber.Text);
            cmd.Parameters.AddWithValue("@itemname", itemname.Text);
            cmd.Parameters.AddWithValue("@price", price.Text);
            cmd.Parameters.AddWithValue("@discount", discount.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            con.Close();

            itemgridview.DataSource = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
           
            SqlCommand command = new SqlCommand("select * from item", con);


            con.Open();

            SqlDataReader DR = command.ExecuteReader();


            BindingSource source = new BindingSource();
            source.DataSource = DR;


            itemgridview.DataSource = source;
        }

        private void clearbutton_Click(object sender, EventArgs e)
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

        private void logout_Click(object sender, EventArgs e)
        {
             this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show(); 
        }

        

        
       
    }
}
