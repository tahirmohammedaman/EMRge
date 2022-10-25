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
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(EMRgeDB.connString))
                {
                    Entities.Employee employee = new Entities.Employee()
                    {
                        ID = Entities.Employee.GenerateEmployeeID(),
                        Department = DropDepartment.SelectedItem.ToString(),
                        FirstName = TbFirstName.Text,
                        MiddleName = TbMiddleName.Text,
                        LastName = TbLastName.Text,
                        Gender = RadioMale.Checked ? "Male" : "Female",
                        DateOfBirth = DateOfBirthPicker.Value,
                        Email = TbEmail.Text,
                        PhoneNumber = DropCountryCode.Text.Substring(DropCountryCode.Text.IndexOf('+')) + TbPhoneNumber.Text,
                        Address = TbAddress.Text,
                        Nationality = DropNationality.SelectedItem.ToString(),
                        Branch = DropBranch.SelectedItem.ToString(),
                        Salary = double.Parse(TbSalary.Text),
                        DateJoined = DateTime.Now,
                        CurrentlyWorking = false,
                        ECName = TbECFirstName.Text + " " + TbECMiddleName.Text + " " + TbECLastName.Text,
                        ECRelation = DropECRelation.SelectedItem.ToString(),
                        ECPhoneNumber = DropECCountryCode.Text.Substring(DropECCountryCode.Text.IndexOf('+')) + TbECPhoneNumber.Text,
                        ECEmail = TbECEmail.Text
                    };
                    employee.Insert();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
