using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMRge.UserControls
{
    public partial class UCMedication : UserControl
    {
        public string MedicationNumber
        {
            get { return MedicationNumber; }
            set { LblMedNo.Text = value; }
        }
        public string Medication
        {
            get { return Medication; }
            set { LblMed.Text = value; }
        }
        public string AlternateMedication
        {
            get { return AlternateMedication; }
            set { LblAlternateMed.Text = "(Alternative) " + value; }
        }
        public UCMedication()
        {
            InitializeComponent();
        }
    }
}
