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
    public partial class GroupStudent : Form
    {
        public GroupStudent()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.Show();
        }
    }
}
