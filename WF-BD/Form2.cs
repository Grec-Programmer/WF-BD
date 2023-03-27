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
using System.Configuration;

namespace WF_BD
{
    public partial class Form2 : Form
    {
        int parsedCustomerId;
        int orderId;
        string cs = ConfigurationManager.ConnectionStrings["Sales"].ConnectionString;
        bool IsCustomerName()
        {
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Введите имя!");
                return false;
            }
            else
                return true;
        }
        bool IsOrder()
        {
            if (txtCustomerId.Text == "")
            {
                MessageBox.Show("Создайте учётную запись");
                return false;
            }
            else if(PriceOrder.Value < 1)
            {
                MessageBox.Show("Введите сумму заказа");
                return false;
            }
            else
                return true;
                
        }
        void ClearForm()
        {
            txtCustomerName.Clear();
            txtCustomerId.Clear();
            dtpOrderDate.Value = DateTime.Now;
            PriceOrder.Value = 0;
            this.parsedCustomerId = 0;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (IsCustomerName())
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    using(SqlCommand cmd = new SqlCommand("Sales.uspNwCustomer",con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
                        cmd.Parameters["@CustomerName"].Value = txtCustomerName.Text;

                        cmd.Parameters.Add(new SqlParameter("@CustomerId", SqlDbType.Int));
                        cmd.Parameters["@CustomerId"].Direction = ParameterDirection.Output;

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();

                            this.parsedCustomerId = (int)cmd.Parameters["@CustomerId"].Value;

                            this.txtCustomerId.Text = Convert.ToString(parsedCustomerId);
                        }
                        catch
                        {
                            MessageBox.Show("ID не был возвращён. Аккаунт не создан");
                        }
                        finally { con.Close(); }
                    }
                }
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (IsOrder())
            {
                using(SqlConnection con = new SqlConnection(cs))
                {
                    using(SqlCommand cmd = new SqlCommand("Sales.uspPlaceNewOrder", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@CustomerId", SqlDbType.Int));
                        cmd.Parameters["@CustomerId"].Value = this.parsedCustomerId;

                        cmd.Parameters.Add(new SqlParameter("@OrderDate", SqlDbType.DateTime, 8));
                        cmd.Parameters["@OrderDate"].Value = dtpOrderDate.Value;

                        cmd.Parameters.Add(new SqlParameter("@Amount",SqlDbType.Int));
                        cmd.Parameters["@Amount"].Value = PriceOrder.Value;

                        cmd.Parameters.Add(new SqlParameter("@Status", SqlDbType.Char, 1));
                        cmd.Parameters["@Status"].Value = 'O';

                        cmd.Parameters.Add(new SqlParameter("@RC", SqlDbType.Int));
                        cmd.Parameters["@RC"].Direction = ParameterDirection.ReturnValue;

                        try
                        {
                            con.Open();

                            cmd.ExecuteNonQuery();

                            this.orderId = (int)cmd.Parameters["@RC"].Value;
                            MessageBox.Show($"Заказ номер {this.orderId} был добавлен");
                        }
                        catch
                        {
                            MessageBox.Show("Заказ не был размещён");
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        private void btnAnotherAccount_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void btnAddFinish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Данные введены верно?","Проверка",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
