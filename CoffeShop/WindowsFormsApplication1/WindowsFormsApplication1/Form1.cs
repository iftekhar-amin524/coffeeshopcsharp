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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-L6M55GH9;" +
                                   "database = coffeeshop;" +
                                   "integrated security = SSPI";
            con.Open();
           
            
            SqlCommand cmd = new SqlCommand("select username,password,position from usr where username='" + usernametextbox.Text + "'and password='" + passwordtextbox.Text + "'", con);
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                string position = string.Empty;

                foreach(DataRow dr in dt.Rows)
                {

                    position = dr["position"].ToString();


                    if (position=="admin     "){
                     this.Hide();
                        Form2 fm2 = new Form2();
                        fm2.Show();
                        MessageBox.Show("Successfully log in");
                        con.Close();
                    
                    }

                    else {
                        this.Hide();
                        Form4 fm4 = new Form4();
                        fm4.Show();
                        MessageBox.Show("Successfully log in");
                        con.Close();
                        
                        }

                }


                       
                        
                    
                    
                    

                   
                
                }
            

                    
            
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Usernamelevel_Click(object sender, EventArgs e)
        {

        }
    }

}
           
       
        






    
