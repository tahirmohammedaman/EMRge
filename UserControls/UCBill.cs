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
    public partial class UCBill : UserControl
    {

        public string BillNumber
        {
            get { return BillNumber; }
            set { LblBillNo.Text = value; }
        }
        public string ServiceType
        {
            get { return ServiceType; }
            set { LblServiceType.Text = value; }
        }
        public string ServicePrice
        {
            get { return ServicePrice; }
            set { LblServicePrice.Text = value; }
        }

        public UCBill()
        {
            InitializeComponent();
        }
    }
}
