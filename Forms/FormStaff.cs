using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMRge
{
    public partial class FormStaff : Form
    {
        // GetAllEmployee Options
        string SearchKey = "", Branch = "", Department = "", MinSalary = "", MaxSalary = "", SortBy = "Department";
        bool Ascending = true;

        public FormStaff()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Forms.FormAddEmployee form = new Forms.FormAddEmployee();
            form.ShowDialog();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            DGVEmployees.DataSource = null;
            DGVEmployees.DataSource = Entities.Employee.GetAllEmployees(SearchKey, Branch, Department, MinSalary, MaxSalary, SortBy, Ascending);
            DGVEmployees.ClearSelection();
        }

        private void DGVEmployees_DoubleClick(object sender, EventArgs e)
        {
            if (DGVEmployees.SelectedRows.Count == 0)
                return;
            Entities.Employee selectedEmployee = DGVEmployees.SelectedRows[0].DataBoundItem as Entities.Employee;
            Forms.FormEmployeeInfo form = new Forms.FormEmployeeInfo(selectedEmployee);
            form.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                SearchKey = TbSearchEmployee.Text;
                MinSalary = TbMinSalary.Text;
                MaxSalary = TbMaxSalary.Text;

                if (DropFilterBranch.SelectedIndex >= 0)
                    Branch = DropFilterBranch.SelectedItem.ToString();
                if (DropFilterDepartment.SelectedIndex >= 0)
                    Department = DropFilterDepartment.SelectedItem.ToString();

                if (RadioSortID.Checked)
                    SortBy = "ID";
                else if (RadioSortName.Checked)
                    SortBy = "FirstName";
                else if (RadioSortSalary.Checked)
                    SortBy = "Salary";
                else
                    SortBy = "Department";

                Ascending = ToggleAscending.Checked;

                DGVEmployees.DataSource = null;
                DGVEmployees.DataSource = Entities.Employee.GetAllEmployees(SearchKey, Branch, Department, MinSalary, MaxSalary, SortBy, Ascending);
                DGVEmployees.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnResetFilters_Click(object sender, EventArgs e)
        {
            TbSearchEmployee.Clear();
            DropFilterBranch.SelectedIndex = -1;
            DropFilterDepartment.SelectedIndex = -1;
            TbMinSalary.Clear();
            TbMaxSalary.Clear();

            RadioSortSalary.Checked = false;
            RadioSortName.Checked = false;
            RadioSortID.Checked = false;
            RadioSortDepartment.Checked = true;

            ToggleAscending.Checked = true;

            SearchKey = "";
            Branch = "";
            Department = "";
            MinSalary = "";
            MaxSalary = "";
            SortBy = "Department";
            Ascending = true;
        }
    }
}
