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
    public partial class FormBilling : Form
    {
        Entities.Patient selectedPatient;
        public FormBilling()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            PanelBills.Controls.Clear();
            selectedPatient = null;

            if (tbSearchByID.Text.Length > 0)
                selectedPatient = Entities.Patient.FindByID(tbSearchByID.Text);
            else if (tbSearchByPhoneNo.Text.Length > 0)
                selectedPatient = Entities.Patient.FindByPhoneNumber(tbSearchByPhoneNo.Text);
            else if (selectedPatient == null)
            {
                MessageBox.Show("No such patient found!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "SELECT * FROM Bill WHERE PatientID = @PatientID AND IsPaid = 0";
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PatientID", selectedPatient.ID);
                    var reader = cmd.ExecuteReader();

                    int billCount = 1;
                    double totalFee = 0;
                    while (reader.Read())
                    {
                        UserControls.UCBill bill = new UserControls.UCBill()
                        {
                            BillNumber = billCount.ToString(),
                            ServiceType = reader["ServiceType"].ToString(),
                            ServicePrice = reader["ServicePrice"].ToString()
                        };
                        totalFee += int.Parse(reader["ServicePrice"].ToString());
                        PanelBills.Controls.Add(bill);
                        billCount++;
                    }
                    LblTotalBill.Text = "Br. " + totalFee.ToString();
                    lblTextTotalStanding.Visible = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnMarkAsPaid_Click(object sender, EventArgs e)
        {
            if (selectedPatient == null)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "UPDATE Bill SET IsPaid = 1 WHERE PatientID = @PatientID";
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PatientID", selectedPatient.ID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("All outstanding bills marked as paid!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBilling_Load(object sender, EventArgs e)
        {

        }
    }
}
