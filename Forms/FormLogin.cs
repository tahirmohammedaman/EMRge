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

namespace EMRge.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "SELECT * FROM EmployeeCredentials WHERE EmployeeID = @ID AND Password = @Password";

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", TbEmployeeID.Text);
                    cmd.Parameters.AddWithValue("@Password", TbPassword.Text);
                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        this.Hide();
                        FormMain form = new FormMain(TbEmployeeID.Text);
                        form.FormClosed += (s, args) => this.Close();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials!");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
