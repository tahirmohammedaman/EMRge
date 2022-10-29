using EMRge.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            errorProvider1.Clear();

            // VALIDATION
            if (String.IsNullOrEmpty(TbFirstName.Text))
                errorProvider1.SetError(TbFirstName, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbMiddleName.Text))
                errorProvider1.SetError(TbMiddleName, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbLastName.Text))
                errorProvider1.SetError(TbLastName, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbEmail.Text))
                errorProvider1.SetError(TbEmail, "This field cannot be empty");
            else if (! new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(TbEmail.Text))
                errorProvider1.SetError(TbEmail, "Invalid email format");
            else if (String.IsNullOrEmpty(TbAddress.Text))
                errorProvider1.SetError(TbAddress, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbPhoneNumber.Text))
                errorProvider1.SetError(TbPhoneNumber, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbHeight.Text))
                errorProvider1.SetError(TbHeight, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbWeight.Text))
                errorProvider1.SetError(TbWeight, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbECFirstName.Text))
                errorProvider1.SetError(TbECFirstName, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbECMiddleName.Text))
                errorProvider1.SetError(TbECMiddleName, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbECLastName.Text))
                errorProvider1.SetError(TbECLastName, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbECPhoneNumber.Text))
                errorProvider1.SetError(TbECPhoneNumber, "This field cannot be empty");
            else if (String.IsNullOrEmpty(TbECEmail.Text))
                errorProvider1.SetError(TbECEmail, "This field cannot be empty");
            else
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

        }

        private void FormAddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
