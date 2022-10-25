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
    public partial class FormExamination : Form
    {

        Entities.ExaminationRecord selectedExam;
        public FormExamination()
        {
            InitializeComponent();
        }

        private void FormExamination_Load(object sender, EventArgs e)
        {
            DGVExaminationQueue.DataSource = null;
            DGVExaminationQueue.DataSource = Entities.ExaminationRecord.GetExaminationRecords();
            DGVExaminationQueue.ClearSelection();                                                                               
        }

        private void BtnAddLabTest_Click(object sender, EventArgs e)
        {
            Forms.FormAddLabTest dialog = new FormAddLabTest(selectedExam);
            dialog.ShowDialog();
        }

        private void BtnAddMedication_Click(object sender, EventArgs e)
        {
            Forms.FormAddMedication dialog = new Forms.FormAddMedication(selectedExam);
            dialog.ShowDialog();
        }

        private void BtnCompleteExamination_Click(object sender, EventArgs e)
        {
            if (selectedExam == null)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    string query = "UPDATE ExaminationRecord SET Diagnosis = @Diagnosis, IsRemovedFromQueue = 1 WHERE ID = @ID";
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Diagnosis", TbDiagnosis.Text);
                    cmd.Parameters.AddWithValue("@ID", selectedExam.ID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Examination record has been submitted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DGVExaminationQueue_DoubleClick(object sender, EventArgs e)
        {
            PanelLabTests.Controls.Clear();
            PanelMedications.Controls.Clear();

            selectedExam = DGVExaminationQueue.SelectedRows[0].DataBoundItem as Entities.ExaminationRecord;
            lblRecordID.Text = selectedExam.ID;
            lblDate.Text = selectedExam.DateAndTime.ToString();
            LblPatientID.Text = selectedExam.PatientID;
            LblPhysicianID.Text = selectedExam.PhysicianID;
            TbDiagnosis.Clear();

            // UPDATE Lab Tests Panel
            List<Entities.LaboratoryTestRecord> laboratoryTestRecords = Entities.LaboratoryTestRecord.GetLaboratoryTestRecords();

            int testCount = 1;
            foreach (var testRecord in laboratoryTestRecords)
            {
                if (testRecord.ExaminationRecordID == selectedExam.ID)
                {
                    UserControls.UCLabTest labTest = new UserControls.UCLabTest();
                    labTest.TestNumber = testCount.ToString();
                    labTest.TestType = testRecord.TestType;
                    labTest.TestResult = (testRecord.Result == " ") ? "(In Queue)" : "Result: " + testRecord.Result;

                    PanelLabTests.Controls.Add(labTest);
                    testCount++;
                }
            }

            // UPDATE Medication PANEL
            List<Entities.MedicationRecord> medicationRecords = Entities.MedicationRecord.GetMedicationRecords();

            int medCount = 1;
            foreach (var medRecord in medicationRecords)
            {
                if (medRecord.ExaminationRecordID == selectedExam.ID)
                {
                    UserControls.UCMedication med = new UserControls.UCMedication();
                    med.MedicationNumber = medCount.ToString();
                    med.Medication = medRecord.Medication;
                    med.AlternateMedication = medRecord.AlternativeMedication;

                    PanelMedications.Controls.Add(med);
                    medCount++;
                }
            }

        }

        private void BtnPatientInfo_Click(object sender, EventArgs e)
        {
            if (selectedExam == null)
                return;

            Entities.Patient patient = Entities.Patient.FindByID(selectedExam.PatientID);
            Forms.FormPatientInfo form = new Forms.FormPatientInfo(patient);
            form.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DGVExaminationQueue.DataSource = null;
            DGVExaminationQueue.DataSource = Entities.ExaminationRecord.GetExaminationRecords();

            lblRecordID.Text = "";
            lblDate.Text = "";
            LblPatientID.Text = "";
            LblPhysicianID.Text = "";
            TbDiagnosis.Clear();

            PanelLabTests.Controls.Clear();
            PanelMedications.Controls.Clear();
        }
    }
}
