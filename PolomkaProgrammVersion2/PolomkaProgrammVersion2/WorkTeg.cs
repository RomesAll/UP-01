using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolomkaProgrammVersion2
{
    public partial class WorkTeg : Form
    {
        public WorkTeg()
        {
            InitializeComponent();
        }

        private void WorkTeg_Load(object sender, EventArgs e)
        {
            ClassClientAddRed.SelectTegAll();
            dataGridView1.DataSource = ClassClientAddRed.DtTegAll;
        }
    }
}
