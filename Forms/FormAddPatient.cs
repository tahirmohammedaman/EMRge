using EMRge.Entities;
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
    public partial class FormAddPatient : Form
    {
        public FormAddPatient()
        {
            InitializeComponent();
        }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                Patient patient = new Patient
                {
                    ID = Entities.Patient.GeneratePatientID(),
                    FirstName = TbFirstName.Text,
                    MiddleName = TbMiddleName.Text,
                    LastName = TbLastName.Text,
                    Gender = RadioMale.Checked ? "Male" : "Female",
                    DateOfBirth = DateOfBirthPicker.Value,
                    Email = TbEmail.Text,
                    PhoneNumber = DropCountryCode.Text.Substring(DropCountryCode.Text.IndexOf('+')) + TbPhoneNumber.Text,
                    Address = TbAddress.Text,
                    Nationality = DropNationality.SelectedItem.ToString(),
                    DateRegistered = DateTime.Now,
                    BranchRegistered = "Addis Ababa",
                    IsInPatient = false,
                    RoomNumber = "-",
                    ECName = TbECFirstName.Text + " " + TbECMiddleName.Text + " " + TbECLastName.Text,
                    ECRelation = DropECRelation.SelectedItem.ToString(),
                    ECPhoneNumber = DropECCountryCode.Text.Substring(DropECCountryCode.Text.IndexOf('+')) + TbECPhoneNumber.Text,
                    ECEmail = TbECEmail.Text,
                    BloodType = DropBloodType.Text,
                    Height = float.Parse(TbHeight.Text),
                    Weight = float.Parse(TbWeight.Text)
                };
                patient.Insert();

                this.Close();
                Forms.FormPatientInfo form = new Forms.FormPatientInfo(patient);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormAddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
