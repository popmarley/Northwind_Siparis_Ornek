using SolutionSepet.Extentions;
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
    public partial class Form2 : Form
    {
        private string customerID;
        public List<int> urunId = new List<int>();
        public List<int> kargoID = new List<int>();

        int id;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string customerID) : this()
        {
            this.customerID = customerID;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            UrunAdGetir();
            KargoAdGetir();
            lblId.Text = customerID;

        }
        public void UrunAdGetir()
        {
            SqlConnection conn = new SqlConnection("server=.;Database=Northwind;Integrated Security = True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select ProductID,ProductName from Products", conn);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                comboBoxurunAd.Items.Add(rdr.GetString(1));
                urunId.Add(rdr.GetInt32(0));



            }
            conn.Close();
        }
        public void KargoAdGetir()
        {
            SqlConnection conn = new SqlConnection("server=.;Database=Northwind;Integrated Security = True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select ShipperID,CompanyName from Shippers", conn);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                comboBoxkargoAd.Items.Add(rdr.GetString(1));
                kargoID.Add(rdr.GetInt32(0));


            }
            conn.Close();
        }
        public bool ValidateOrder()
        {
            return textBoxGemiAd.Text.IsValidEmptyString()
                && textBoxAdres.Text.IsValidEmptyNumeric()
                && textBoxsehir.Text.IsValidEmptyString()
                && InputValidations.ValidateDateRange(dateTimePickersiparis.Value, dateTimePickerkargo.Value)
                && textBoxKargoUcreti.Text.IsValidEmptyNumeric()
                && comboBoxkargoAd.IsNotEmptyComboBox()
                && comboBoxurunAd.IsNotEmptyComboBox();



        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {

            if (ValidateOrder() == true)
            {

                SqlConnection conn = new SqlConnection("server=.;Database=Northwind;Integrated Security = True");

                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("insert Orders( CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity) values(@customerId,1,@orderDate,@requiredDate,@shippedDate,@ShipVia,@freight,@shipName,@shipAddress,@shipCity); SELECT SCOPE_IDENTITY()", conn);

                    cmd.Parameters.AddWithValue("@customerId", customerID);
                    cmd.Parameters.AddWithValue("@orderDate", dateTimePickersiparis.Value);
                    cmd.Parameters.AddWithValue("@requiredDate", dateTimePickeristenen.Value);
                    cmd.Parameters.AddWithValue("@shippedDate", dateTimePickerkargo.Value);
                    cmd.Parameters.AddWithValue("@ShipVia", kargoID[comboBoxkargoAd.SelectedIndex]);
                    cmd.Parameters.AddWithValue("@freight", Convert.ToDecimal(textBoxKargoUcreti.Text));
                    cmd.Parameters.AddWithValue("@shipName", textBoxGemiAd.Text);
                    cmd.Parameters.AddWithValue("@shipAddress", textBoxAdres.Text);
                    cmd.Parameters.AddWithValue("@shipCity", textBoxsehir.Text);

                    cmd.ExecuteNonQuery();
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();
                    MessageBox.Show("Siparişiniz Alındı");
                    groupBox1.Visible = true;
                }
                catch (Exception ex)
                {
                    label14.Text = ex.Message;

                    groupBox1.Visible = false;

                }
                finally
                {
                    conn.Close();
                }
                label14.Text = id.ToString();
                lblurunId.Text = urunId[comboBoxurunAd.SelectedIndex].ToString();

            }
            else MessageBox.Show("Hata");

        }
        public bool ValidateDetails()
        {
            return textBoxSatisFiyat.Text.IsValidEmptyNumeric() && numericUpDownAdet.Value != 0 && textBoxIndırım.Text.IsValidEmptyNumeric();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateDetails() == true)
            {

                SqlConnection conn = new SqlConnection("server=.;Database=Northwind;Integrated Security = True");
                try
                {
                    conn.Open();


                    SqlCommand cmd2 = new SqlCommand("insert [Order Details] (OrderID,ProductID,UnitPrice,Quantity,Discount)values(@orderId,@productId,@unitPrice,@quantity,@discount)", conn);

                    cmd2.Parameters.AddWithValue("@orderId", id);
                    cmd2.Parameters.AddWithValue("@productId", urunId[comboBoxurunAd.SelectedIndex]);
                    cmd2.Parameters.AddWithValue("@unitPrice", Convert.ToDecimal(textBoxSatisFiyat.Text));
                    cmd2.Parameters.AddWithValue("@quantity", Convert.ToInt16(numericUpDownAdet.Value));
                    cmd2.Parameters.AddWithValue("@discount", (Convert.ToDouble(textBoxIndırım.Text)) / 100);

                    cmd2.ExecuteNonQuery();



                    MessageBox.Show("Siparişiniz Alındı");
                }
                catch (Exception ex)
                {
                    label14.Text = ex.Message;


                }
                finally
                {
                    conn.Close();
                }
            }
            else MessageBox.Show("Hata");


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKargoUcreti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxSatisFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxIndırım_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
