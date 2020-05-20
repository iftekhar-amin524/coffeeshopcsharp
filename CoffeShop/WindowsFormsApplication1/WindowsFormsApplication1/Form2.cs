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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection();


            con.ConnectionString = "data source = LAPTOP-L6M55GH9;" +
                                   "database = coffeeshop;" +
                                   "integrated security = SSPI";

            SqlCommand command = new SqlCommand("select * from usr", con);


            con.Open();

            SqlDataReader DR = command.ExecuteReader();


            BindingSource source = new BindingSource();
            source.DataSource = DR;


            usrgridview.DataSource = source;


            con.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";

            //Generating SQL Query
            string sql = "INSERT INTO usr(username,password,position) VALUES(@param1,@param2,@param3)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.Add("@param1", SqlDbType.VarChar).Value = usrntextbox.Text;
                cmd.Parameters.Add("@param2", SqlDbType.VarChar).Value = passtextbox.Text;
                cmd.Parameters.Add("@param3", SqlDbType.VarChar).Value = positiontextbox.Text;


                cmd.CommandType = CommandType.Text;
               

                int i = cmd.ExecuteNonQuery();

                con.Close();

                if (i != 0)
                {
                    MessageBox.Show(i + "Data Saved");
                }

                //Disconnect
                con.Close();


                usrgridview.DataSource = "data source =LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
                usrgridview.Refresh();
                SqlCommand command = new SqlCommand("select * from usr", con);


                con.Open();

                SqlDataReader DR = command.ExecuteReader();


                BindingSource source = new BindingSource();
                source.DataSource = DR;
                 

                usrgridview.DataSource = source;




            }

        }



        private void usrgridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = usrgridview.Rows[e.RowIndex]; 
                idtextbox.Text = row.Cells[0].Value.ToString();
                usrntextbox.Text = row.Cells[1].Value.ToString();
                passtextbox.Text = row.Cells[2].Value.ToString();
                positiontextbox.Text = row.Cells[3].Value.ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //ConnectionString:
            con.ConnectionString = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";

            SqlCommand cmd;



            cmd = new SqlCommand("Delete from usr  where autoid=@autoid", con);
            con.Open();
            cmd.Parameters.AddWithValue("@autoid", idtextbox.Text);
            cmd.Parameters.AddWithValue("@username", usrntextbox.Text);
            cmd.Parameters.AddWithValue("@password", passtextbox.Text);
            cmd.Parameters.AddWithValue("@position", positiontextbox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            con.Close();

            usrgridview.DataSource = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
            usrgridview.Refresh();
            SqlCommand command = new SqlCommand("select * from usr", con);


            con.Open();

            SqlDataReader DR = command.ExecuteReader();


            BindingSource source = new BindingSource();
            source.DataSource = DR;


            usrgridview.DataSource = source;
            
            
            
        }

        

      

        private void button3_Click(object sender, EventArgs e)
        {
            //Initiating SQL Connection:
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
            SqlCommand cmd;
            
         
            if (usrntextbox.Text != "" && passtextbox.Text != "" && positiontextbox.Text != "")
            {
                cmd = new SqlCommand("update usr set username=@username,password=@password,position=@position where autoid=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", idtextbox.Text);
                cmd.Parameters.AddWithValue("@username", usrntextbox.Text);
                cmd.Parameters.AddWithValue("@password", passtextbox.Text);
                cmd.Parameters.AddWithValue("@position", positiontextbox.Text);
               cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();

                usrgridview.DataSource = "data source = LAPTOP-L6M55GH9;database = coffeeshop;integrated security = SSPI";
                usrgridview.Refresh();
                SqlCommand command = new SqlCommand("select * from usr", con);


                con.Open();

                SqlDataReader DR = command.ExecuteReader();


                BindingSource source = new BindingSource();
                source.DataSource = DR;


                usrgridview.DataSource = source;


                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }  
        }


        private void button5_Click(object sender, EventArgs e)
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

        private void gotoitemtable_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fm3 = new Form3();
            fm3.Show();
        }

        private void gotoselltable_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 fm5 = new Form5();
            fm5.Show();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        

       

       

        




    }
}

