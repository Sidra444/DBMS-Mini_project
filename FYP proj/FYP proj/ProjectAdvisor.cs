using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYP_proj
{
    public partial class ProjectAdvisor : Form
    {
        public ProjectAdvisor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Evaluation eva = new Evaluation();
            eva.Show();
        }
    }
}
