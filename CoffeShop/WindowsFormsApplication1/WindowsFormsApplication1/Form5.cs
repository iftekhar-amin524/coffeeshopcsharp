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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           

            SqlConnection con = new SqlConnection();


            con.ConnectionString = "data source =LAPTOP-L6M55GH9;" +
                                   "database = coffeeshop;" +
                                   "integrated security = SSPI";

            SqlCommand command = new SqlCommand("select * from placeorder", con);
            

            con.Open();

            SqlDataReader DR = command.ExecuteReader();
            


            BindingSource source = new BindingSource();
            source.DataSource = DR;
            


            selldetailsgrid.DataSource = source;
            con.Close();

        }
    }
}
