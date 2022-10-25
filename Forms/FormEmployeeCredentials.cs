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
    public partial class FormEmployeeCredentials : Form
    {
        Entities.Employee employee;
        public FormEmployeeCredentials(Entities.Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
            int[] credentials = Entities.Employee.GetCredentials(employee.ID);

            CheckBox1.Checked = (credentials[0] == 1);
            CheckBox2.Checked = (credentials[1] == 1);
            CheckBox3.Checked = (credentials[2] == 1);
            CheckBox4.Checked = (credentials[3] == 1);
            CheckBox5.Checked = (credentials[4] == 1);
            CheckBox6.Checked = (credentials[5] == 1);
            CheckBox7.Checked = (credentials[6] == 1);
            CheckBox8.Checked = (credentials[7] == 1);
            CheckBox9.Checked = (credentials[8] == 1);
            CheckBox10.Checked = (credentials[9] == 1);
            CheckBox11.Checked = (credentials[10] == 1);
            CheckBox12.Checked = (credentials[11] == 1);
            CheckBox13.Checked = (credentials[12] == 1);
            CheckBox14.Checked = (credentials[13] == 1);
            CheckBox15.Checked = (credentials[14] == 1);
            CheckBox16.Checked = (credentials[15] == 1);
            CheckBox17.Checked = (credentials[16] == 1);
        }

        private void FormEmployeeCredentials_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdateCredentials_Click(object sender, EventArgs e)
        {
            int[] credentials = new int[17];
            credentials[0] = CheckBox1.Checked ? 1 : 0;
            credentials[1] = CheckBox2.Checked ? 1 : 0;
            credentials[2] = CheckBox3.Checked ? 1 : 0;
            credentials[3] = CheckBox4.Checked ? 1 : 0;
            credentials[4] = CheckBox5.Checked ? 1 : 0;
            credentials[5] = CheckBox6.Checked ? 1 : 0;
            credentials[6] = CheckBox7.Checked ? 1 : 0;
            credentials[7] = CheckBox8.Checked ? 1 : 0;
            credentials[8] = CheckBox9.Checked ? 1 : 0;
            credentials[9] = CheckBox10.Checked ? 1 : 0;
            credentials[10] = CheckBox11.Checked ? 1 : 0;
            credentials[11] = CheckBox12.Checked ? 1 : 0;
            credentials[12] = CheckBox13.Checked ? 1 : 0;
            credentials[13] = CheckBox14.Checked ? 1 : 0;
            credentials[14] = CheckBox15.Checked ? 1 : 0;
            credentials[15] = CheckBox16.Checked ? 1 : 0;
            credentials[16] = CheckBox17.Checked ? 1 : 0;

            employee.UpdateCredentials(credentials);
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            CheckBox1.Checked = true;
            CheckBox2.Checked = true;
            CheckBox3.Checked = true;
            CheckBox4.Checked = true;
            CheckBox5.Checked = true;
            CheckBox6.Checked = true;
            CheckBox7.Checked = true;
            CheckBox8.Checked = true;
            CheckBox9.Checked = true;
            CheckBox10.Checked = true;
            CheckBox11.Checked = true;
            CheckBox12.Checked = true;
            CheckBox13.Checked = true;
            CheckBox14.Checked = true;
            CheckBox15.Checked = true;
            CheckBox16.Checked = true;
            CheckBox17.Checked = true;
        }

        private void BtnUnselectAll_Click(object sender, EventArgs e)
        {
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
            CheckBox5.Checked = false;
            CheckBox6.Checked = false;
            CheckBox7.Checked = false;
            CheckBox8.Checked = false;
            CheckBox9.Checked = false;
            CheckBox10.Checked = false;
            CheckBox11.Checked = false;
            CheckBox12.Checked = false;
            CheckBox13.Checked = false;
            CheckBox14.Checked = false;
            CheckBox15.Checked = false;
            CheckBox16.Checked = false;
            CheckBox17.Checked = false;
        }
    }
}
