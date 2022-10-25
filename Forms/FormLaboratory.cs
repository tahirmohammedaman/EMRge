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

namespace EMRge.Forms
{
    public partial class FormLaboratory : Form
    {
        Entities.LaboratoryTestRecord selectedLabTest;
        public FormLaboratory()
        {
            InitializeComponent();
        }

        private void FormLaboratory_Load(object sender, EventArgs e)
        {
            List<Entities.LaboratoryTestRecord> records = Entities.LaboratoryTestRecord.GetLaboratoryTestRecords();

            try
            {
                foreach (var record in records.ToList())
                {
                    if (record.IsRemovedFromQueue)
                        records.Remove(record);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DGVLaboratoryQueue.DataSource = null;
            DGVLaboratoryQueue.DataSource = records;
        }

        private void DGVLaboratoryQueue_DoubleClick(object sender, EventArgs e)
        {
            selectedLabTest = DGVLaboratoryQueue.SelectedRows[0].DataBoundItem as Entities.LaboratoryTestRecord;
            LblExaminationID.Text = selectedLabTest.ExaminationRecordID;
            LblDate.Text = selectedLabTest.DateAndTime.ToString();
            LblTestType.Text = selectedLabTest.TestType;
            LblPatientID.Text = selectedLabTest.PatientID;
            LblLabPhysicianID.Text = FormMain.LoggedInEmployeeID;

            TbResults.Clear();
        }

        private void BtnSubmitResults_Click(object sender, EventArgs e)
        {
            if (selectedLabTest == null)
                return;
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "UPDATE LaboratoryTestRecord SET Result = @Result, IsRemovedFromQueue = 1, LabPhysicianID = @LabPhysicianID WHERE ID = @ID";
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Result", TbResults.Text);
                    cmd.Parameters.AddWithValue("@ID", selectedLabTest.ID);
                    cmd.Parameters.AddWithValue("@LabPhysicianID", FormMain.LoggedInEmployeeID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Laboratory test results submitted successfully!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPatientInfo_Click(object sender, EventArgs e)
        {
            if (selectedLabTest == null)
                return;

            Entities.Patient patient = Entities.Patient.FindByID(selectedLabTest.PatientID);
            Forms.FormPatientInfo form = new Forms.FormPatientInfo(patient);
            form.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            List<Entities.LaboratoryTestRecord> records = Entities.LaboratoryTestRecord.GetLaboratoryTestRecords();
            try
            {
                foreach (var record in records.ToList())
                {
                    if (record.IsRemovedFromQueue)
                        records.Remove(record);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DGVLaboratoryQueue.DataSource = null;
            DGVLaboratoryQueue.DataSource = records;

            // Clear labels

            LblExaminationID.Text = "";
            LblDate.Text = "";
            LblTestType.Text = "";
            LblPatientID.Text = "";
            LblLabPhysicianID.Text = "";
            TbResults.Clear();
        }
    }
}
