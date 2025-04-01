using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Manager
{
    public class HunterBaseControl : UserControl
    {
        public int HunterID { get; set; }
        public int CompanyID { get; set; }

        public virtual void DisplayDetails() { }
    }
}
