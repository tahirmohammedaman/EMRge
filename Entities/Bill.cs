using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMRge.Entities
{
    internal class Bill
    {
        public string ID { get; set; }
        public string PatientID { get; set; }
        public string ServiceType { get; set; }
        public string ServicePrice { get; set; }
    }
}
