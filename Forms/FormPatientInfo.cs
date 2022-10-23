using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMRge.Forms
{
    public partial class FormPatientInfo : Form
    {
        Entities.Patient selectedPatient;
        public FormPatientInfo(Entities.Patient patient, bool ShowAddToExamQueue = false)
        {
            InitializeComponent();

            selectedPatient = patient;
            
            lblPatientID.Text = patient.ID;
            lblName.Text = patient.FirstName + " " + patient.MiddleName + " " + patient.LastName;

            // Calculate Patient Age
            int age = DateTime.Today.Year - patient.DateOfBirth.Year;

            if (patient.DateOfBirth.Date > DateTime.Today.AddYears(-age)) 
                age--;

            lblAgeGender.Text = age.ToString() + ", " + patient.Gender;
            lblDOB.Text = patient.DateOfBirth.ToLongDateString().Substring(patient.DateOfBirth.ToLongDateString().IndexOf(" ") + 1);
            lblEmail.Text = patient.Email;
            lblPhoneNo.Text = patient.PhoneNumber;
            lblAddress.Text = patient.Address;
            lblBloodType.Text = patient.BloodType;
            lblHeight.Text = patient.Height.ToString();
            lblWeight.Text = patient.Weight.ToString();
            lblECEmail.Text = patient.ECEmail;
            lblECName.Text = patient.ECName;
            lblECRelation.Text = patient.ECRelation;
            lblECPhoneNo.Text = patient.ECPhoneNumber;
            lblBranchRegistered.Text = patient.BranchRegistered;
            lblDateRegistered.Text = patient.DateRegistered.ToLongDateString().Substring(patient.DateRegistered.ToLongDateString().IndexOf(" ") + 1);

            Entities.ExaminationRecord recentExaminationRecord = patient.GetRecentExaminationRecord();
            if (recentExaminationRecord != null)
            {
                lblRecExamID.Text = recentExaminationRecord.ID;
                lblRecentExamDate.Text = recentExaminationRecord.DateAndTime.ToLongDateString();
                lblRecExamDate.Text = recentExaminationRecord.DateAndTime.ToString();
                lblRecPhysicianID.Text = recentExaminationRecord.PhysicianID;
                TbDiagnosis.Text = recentExaminationRecord.Diagnosis;
            }

            if (ShowAddToExamQueue)
                PanelAddToExamQueue.Visible = true;
                
        }

        private void FormPatientInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnEditRecord_Click(object sender, EventArgs e)
        {
            Forms.FormEditPatient dialog = new Forms.FormEditPatient(selectedPatient);
            this.Close();
            dialog.ShowDialog();
        }

        private void BtnDeleteRecord_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to delete Patient " + selectedPatient.ID + " Record?", "Delete Patient Record?", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
                selectedPatient.Delete();
        }

        private void BtnAddToExaminationQueue_Click(object sender, EventArgs e)
        {
            Entities.ExaminationRecord examinationRecord = new Entities.ExaminationRecord()
            {
                DateAndTime = DateTime.Now,
                PatientID = selectedPatient.ID,
                PhysicianID = FormMain.LoggedInEmployeeID
            };
            examinationRecord.Insert();
        }
    }
}
