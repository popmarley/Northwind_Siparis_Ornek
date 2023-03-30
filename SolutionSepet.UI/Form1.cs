using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionSepet.UI
{

    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        string customerID;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (sirketId.Text==""||companyName.Text=="")
            {
                MessageBox.Show("Alanlar boş geçilemez");
               

            }else
            {
                SqlConnection conn = new SqlConnection("server=.;Database=Northwind;Integrated Security = True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert Customers(CustomerID,CompanyName) values (@Id,@companyName)", conn);
                cmd.Parameters.AddWithValue("@Id", sirketId.Text);
                cmd.Parameters.AddWithValue("@companyName", companyName.Text);
                customerID = sirketId.Text;

                cmd.ExecuteNonQuery();
                conn.Close();
                Form2 frm = new Form2(customerID);
                frm.Show();
            }
        }
       
        }
    
}
