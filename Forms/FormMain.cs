using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EMRge
{
    public partial class FormMain : Form
    {
        public static string LoggedInEmployeeID;
        public static int[] LoggedInEmployeeCredentials;

        public FormMain(string _LoggedInEmployeeID)
        {
            InitializeComponent();
            LoggedInEmployeeID = _LoggedInEmployeeID;
            LoggedInEmployeeCredentials = Entities.Employee.GetCredentials(LoggedInEmployeeID);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;

            LblLoggedAs.Text += " " + LoggedInEmployeeID;
            LblDate.Text = DateTime.Now.ToLongDateString();

            Forms.FormDashboard child = new Forms.FormDashboard();
            child.MdiParent = this;
            child.Show();

            LblHospitalName.Visible = false;
            LblHospitalMotto.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Forms.FormDashboard child = new Forms.FormDashboard();
            child.MdiParent = this;
            child.Show();

            LblHospitalName.Visible = false;
            LblHospitalMotto.Visible = false;
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            if (LoggedInEmployeeCredentials[0] == 1)
            {
                Forms.FormPatients child = new Forms.FormPatients();
                child.MdiParent = this;
                child.Show();
            }
            else
            {
                Forms.FormInvalidCredentials child = new Forms.FormInvalidCredentials();
                child.MdiParent = this;
                child.Show();
            }

            LblHospitalName.Visible = true;
            LblHospitalMotto.Visible = true;
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            if (LoggedInEmployeeCredentials[4] == 1)
            {
                Forms.FormExamination child = new Forms.FormExamination();
                child.MdiParent = this;
                child.Show();
            }
            else
            {
                Forms.FormInvalidCredentials child = new Forms.FormInvalidCredentials();
                child.MdiParent = this;
                child.Show();
            }

            LblHospitalName.Visible = true;
            LblHospitalMotto.Visible = true;
        }

        private void btnLaboratory_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            if (LoggedInEmployeeCredentials[5] == 1)
            {
                Forms.FormLaboratory child = new Forms.FormLaboratory();
                child.MdiParent = this;
                child.Show();
            }
            else
            {
                Forms.FormInvalidCredentials child = new Forms.FormInvalidCredentials();
                child.MdiParent = this;
                child.Show();
            }

            LblHospitalName.Visible = true;
            LblHospitalMotto.Visible = true;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Forms.FormInvalidCredentials child = new Forms.FormInvalidCredentials();
            child.MdiParent = this;
            child.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            if (LoggedInEmployeeCredentials[11] == 1)
            {
                FormStaff child = new FormStaff();
                child.MdiParent = this;
                child.Show();
            }
            else
            {
                Forms.FormInvalidCredentials child = new Forms.FormInvalidCredentials();
                child.MdiParent = this;
                child.Show();
            }

            LblHospitalName.Visible = true;
            LblHospitalMotto.Visible = true;
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            if (LoggedInEmployeeCredentials[11] == 1)
            {
                Forms.FormBilling child = new Forms.FormBilling();
                child.MdiParent = this;
                child.Show();
            }
            else
            {
                Forms.FormInvalidCredentials child = new Forms.FormInvalidCredentials();
                child.MdiParent = this;
                child.Show();
            }

            LblHospitalName.Visible = true;
            LblHospitalMotto.Visible = true;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            // LogOutButton
            this.Hide();
            Forms.FormLogin form = new Forms.FormLogin();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
    }
}
