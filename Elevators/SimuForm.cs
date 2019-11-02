using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevators
{
    public partial class SimuForm : Form
    {
        public SimuForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void Form2_Close(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
