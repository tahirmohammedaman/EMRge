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
    public partial class FormAddLabTest : Form
    {
        static string[] TestNames = {"DAO (Histamine intolerance)", "IgE", "Typtase", "AMH", "HOMA index", "Insulin", "Insulin-like Growth Factor", "Testosterone", "Vitamin A", "Ca (Calcium)", "Uric Acid", "Urine Sodium", "Kidney Stone Analysis", "Cholesterol", "Faecal culture", "Faecal calprotectin", "Elastase", "Human Haemoglobin", "Glans Culture", "Semen Culture", "Wound Culture", "Group B Streptococcus screening", "Iodine", "Microalbumin", "Urine Protein"};

        List<Bunifu.UI.WinForms.BunifuCheckBox> checkBoxes = new List<Bunifu.UI.WinForms.BunifuCheckBox>();

        Entities.ExaminationRecord examinationRecord;

        public FormAddLabTest(Entities.ExaminationRecord examinationRecord)
        {
            InitializeComponent();
            this.examinationRecord = examinationRecord;

            checkBoxes.Add(CheckBox0);
            checkBoxes.Add(CheckBox1);
            checkBoxes.Add(CheckBox2);
            checkBoxes.Add(CheckBox3);
            checkBoxes.Add(CheckBox4);
            checkBoxes.Add(CheckBox5);
            checkBoxes.Add(CheckBox6);
            checkBoxes.Add(CheckBox7);
            checkBoxes.Add(CheckBox8);
            checkBoxes.Add(CheckBox9);
            checkBoxes.Add(CheckBox10);
            checkBoxes.Add(CheckBox11);
            checkBoxes.Add(CheckBox12);
            checkBoxes.Add(CheckBox13);
            checkBoxes.Add(CheckBox14);
            checkBoxes.Add(CheckBox15);
            checkBoxes.Add(CheckBox16);
            checkBoxes.Add(CheckBox17);
            checkBoxes.Add(CheckBox18);
            checkBoxes.Add(CheckBox19);
            checkBoxes.Add(CheckBox20);
            checkBoxes.Add(CheckBox21);
            checkBoxes.Add(CheckBox22);
            checkBoxes.Add(CheckBox23);
            checkBoxes.Add(CheckBox24);
        }

        private void FormAddLabTest_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnAddTests_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                foreach (var checkbox in checkBoxes)
                {
                    if (checkbox.Checked)
                    {
                        Entities.LaboratoryTestRecord newLabTest = new Entities.LaboratoryTestRecord()
                        {
                            ExaminationRecordID = examinationRecord.ID,
                            DateAndTime = DateTime.Now,
                            PatientID = examinationRecord.PatientID,
                            LabPhysicianID = " ",
                            TestType = TestNames[count],
                            Result = " "
                        };
                        newLabTest.Insert();
                    }
                    count++;
                }
                MessageBox.Show("Selected tests ordered successfully!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
