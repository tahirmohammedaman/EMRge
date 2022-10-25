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
    public partial class UCLabTest : UserControl
    {
        public string TestNumber
        {
            get { return TestNumber; } set { LblTestNo.Text = value; }
        }
        public string TestType
        {
            get { return TestType; }
            set { LblTestType.Text = value; }
        }
        public string TestResult
        {
            get { return TestResult; }
            set { LblTestResult.Text = value; }
        }
        public UCLabTest()
        {
            InitializeComponent();
        }
    }
}
