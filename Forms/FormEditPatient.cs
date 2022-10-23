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
    public partial class FormEditPatient : Form
    {

        Entities.Patient selectedPatient;
        public FormEditPatient(Entities.Patient patient)
        {
            InitializeComponent();

            selectedPatient = patient;

            lblPatientID.Text += patient.ID;
            tbFirstName.Text = patient.FirstName;
            tbMiddleName.Text = patient.MiddleName;
            tbLastName.Text = patient.LastName;
            tbAddress.Text = patient.Address;
            TbPhoneNo.Text = patient.PhoneNumber;
            TbEmail.Text = patient.Email;
            TbHeight.Text = patient.Height.ToString();
            TbWeight.Text = patient.Weight.ToString();
            TbECName.Text = patient.ECName;
            TbECEmail.Text = patient.ECEmail;
            TbECPhoneNo.Text = patient.ECPhoneNumber;

            if (patient.Gender == "Male")
            {
                RadioFemale.Checked = false;
                RadioMale.Checked = true;
            }
            else
            {
                RadioMale.Checked = false;
                RadioFemale.Checked = true;
            }

            DatePickerDOB.Value = patient.DateOfBirth;

            DropBloodType.SelectedItem = patient.BloodType;
            DropNationality.SelectedItem = patient.Nationality;
            DropECRelation.SelectedItem = patient.ECRelation;
        }

        private void FormEditPatient_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnConfirmEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.Patient updatedPatient = new Entities.Patient()
                {
                    ID = selectedPatient.ID,
                    FirstName = tbFirstName.Text,
                    MiddleName = tbMiddleName.Text,
                    LastName = tbLastName.Text,
                    Gender = RadioMale.Checked ? "Male" : "Female",
                    DateOfBirth = DatePickerDOB.Value,
                    Email = TbEmail.Text,
                    PhoneNumber = TbPhoneNo.Text,
                    Address = tbAddress.Text,
                    Nationality = DropNationality.SelectedItem.ToString(),
                    DateRegistered = selectedPatient.DateRegistered,
                    BranchRegistered = selectedPatient.BranchRegistered,
                    IsInPatient = selectedPatient.IsInPatient,
                    RoomNumber = selectedPatient.RoomNumber,
                    BloodType = DropBloodType.SelectedItem.ToString(),
                    Height = float.Parse(TbHeight.Text),
                    Weight = float.Parse(TbWeight.Text),
                    ECRelation = DropECRelation.SelectedItem.ToString(),
                    ECName = TbECName.Text,
                    ECEmail = TbECEmail.Text,
                    ECPhoneNumber = TbECPhoneNo.Text
                };

                selectedPatient.Update(updatedPatient);

                this.Close();
                Forms.FormPatientInfo form = new Forms.FormPatientInfo(updatedPatient);
                form.Show();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
