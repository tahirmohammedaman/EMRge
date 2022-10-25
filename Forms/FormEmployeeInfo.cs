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
    public partial class FormEmployeeInfo : Form
    {
        Entities.Employee employee;
        public FormEmployeeInfo(Entities.Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void FormEmployeeInfo_Load(object sender, EventArgs e)
        {
            LblDepartment.Text = employee.Department;
            LblBranch.Text = employee.Branch;
            LblID.Text = employee.ID;
            LblDateJoined.Text = employee.DateJoined.ToLongDateString().Substring(employee.DateJoined.ToLongDateString().IndexOf(" ") + 1);
            LblName.Text = employee.FirstName + " " + employee.MiddleName + " " + employee.LastName;

            // Calculate Age
            int age = DateTime.Today.Year - employee.DateOfBirth.Year;
            if (employee.DateOfBirth.Date > DateTime.Today.AddYears(-age))
                age--;
            LblAgeGender.Text = age.ToString() + ", " + employee.Gender;
            LblDateOfBirth.Text = employee.DateOfBirth.ToLongDateString().Substring(employee.DateOfBirth.ToLongDateString().IndexOf(" ") + 1);
            LblNationality.Text = employee.Nationality;
            LblEmail.Text = employee.Email;
            LblAddress.Text = employee.Address;
            LblPhoneNumber.Text = employee.PhoneNumber;

            LblECEmail.Text = employee.ECEmail;
            LblECName.Text = employee.ECName;
            LblECRelation.Text = employee.ECRelation;
            LblECPhoneNumber.Text = employee.ECPhoneNumber;

            if (!employee.CurrentlyWorking)
            {
                CircleCurrentlyWorking.FillColor = Color.Maroon;
                LblCurrentlyWorking.Text = "Not Currently Working";
            }

            // WTFFF IS GOING ON
            LblTextPersonalInformation.Text = "Personal Information";
            LblTextEmergencyContact.Text = "Emergency Contact Information";
            LblTextBranch.Text = "Branch";
            LblTextDepartment.Text = "Department";
            LblTextEmployeeID.Text = "Employee ID";
            LblTextDateJoined.Text = "Date Joined";
            LblTextDOB.Text = "Date of Birth";
            LblTextAddress.Text = "Address";
            LblTextPhoneNo.Text = "Phone Number";
            LblTextEmail.Text = "Email Address";
            LblTextECRelation.Text = "Relationship";
            LblTextECName.Text = "Full Name";
            LblTextECPhoneNo.Text = "Phone Number";
            LblTextECEmail.Text = "Email Address";
        }

        private void BtnManageCredentials_Click(object sender, EventArgs e)
        {
            Forms.FormEmployeeCredentials dialog = new Forms.FormEmployeeCredentials(employee);
            dialog.ShowDialog();
        }

    }
}
