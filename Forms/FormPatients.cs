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
    public partial class FormPatients : Form
    {
        public FormPatients()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            Forms.FormAddPatient form = new Forms.FormAddPatient();
            form.ShowDialog();
        }

        private void FormPatients_Load(object sender, EventArgs e)
        {
            DGVOutPatients.DataSource = null;
            DGVOutPatients.DataSource = Entities.Patient.GetAllOutPatients();
            DGVOutPatients.ClearSelection();
            // --
            DGVInPatients.DataSource = null;
            DGVInPatients.DataSource = Entities.Patient.GetAllInPatients();
            DGVInPatients.ClearSelection();
        }

        private void DGVOutPatients_DoubleClick(object sender, EventArgs e)
        {
            if (DGVOutPatients.SelectedRows.Count == 0)
                return;

            Entities.Patient selectedPatient = DGVOutPatients.SelectedRows[0].DataBoundItem as Entities.Patient;
            Forms.FormPatientInfo form = new Forms.FormPatientInfo(selectedPatient, true);
            form.Show();
        }

        private void DGVInPatients_DoubleClick(object sender, EventArgs e)
        {
            if (DGVOutPatients.SelectedRows.Count == 0)
                return;
            Entities.Patient selectedPatient = DGVOutPatients.SelectedRows[0].DataBoundItem as Entities.Patient;
            Forms.FormPatientInfo form = new Forms.FormPatientInfo(selectedPatient, true);
            form.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            DGVOutPatients.DataSource = null;
            DGVOutPatients.DataSource = Entities.Patient.GetAllOutPatients();
            DGVOutPatients.ClearSelection();
            // --
            DGVInPatients.DataSource = null;
            DGVInPatients.DataSource = Entities.Patient.GetAllInPatients();
            DGVInPatients.ClearSelection();
        }

        private void BtnSearchByPatientID_Click(object sender, EventArgs e)
        {
            Entities.Patient patient = Entities.Patient.FindByID(TbSearchByID.Text);
            if (patient.ID == null)
            {
                MessageBox.Show("No patient by such ID: " + TbSearchByID.Text);
                return;
            }
            Forms.FormPatientInfo form = new Forms.FormPatientInfo(patient, true);
            form.Show();
        }

        private void BtnSearchByPhoneNo_Click(object sender, EventArgs e)
        {
            Entities.Patient patient = Entities.Patient.FindByPhoneNumber(TbSearchByPhoneNo.Text);
            if (patient.ID == null)
            {
                MessageBox.Show("No patient by such phone number: " + TbSearchByPhoneNo.Text);
                return;
            }
            Forms.FormPatientInfo form = new Forms.FormPatientInfo(patient, true);
            form.Show();
        }
    }
}
