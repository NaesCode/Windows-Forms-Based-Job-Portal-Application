using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Application_Manager
{
    public class BaseControl : UserControl
    {
        public int HunterID { get; set; }
        public int CompanyID { get; set; }

        public byte[]? imageData { get; set;}

        internal DatabaseSupport dbSupport = new DatabaseSupport();

        public virtual void DisplayDetails() { }

        public virtual void LoadDataGrid() { }
    }
}
