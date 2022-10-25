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
    public partial class FormAddMedication : Form
    {
        Entities.ExaminationRecord selectedExam;
        public FormAddMedication(Entities.ExaminationRecord selectedExam)
        {
            InitializeComponent();
            this.selectedExam = selectedExam;
        }

        private void BtnAddMedication_Click(object sender, EventArgs e)
        {
            Entities.MedicationRecord medicationRecord = new Entities.MedicationRecord()
            {
                ExaminationRecordID = selectedExam.ID,
                Medication = TbMedication.Text,
                AlternativeMedication = TbAlternativeMedication.Text
            };
            medicationRecord.Insert();
        }
    }
}
