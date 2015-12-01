using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlamingoWF
{
    public partial class ViewAttendence : Form
    {
        public ViewAttendence()
        {
            InitializeComponent();
        }

        private void ViewAttendence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flamingoWindowsapplicationDbDataSet.Attendence' table. You can move, or remove it, as needed.
            this.attendenceTableAdapter.Fill(this.flamingoWindowsapplicationDbDataSet.Attendence);

        }
    }
}
