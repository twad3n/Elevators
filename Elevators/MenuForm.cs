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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(800, 600);
            this.MaximumSize = new Size(800, 600);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formSimu = new SimuForm();
            this.Hide();
            formSimu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formSettings = new SettingsForm();
            //this.Hide();
            formSettings.ShowDialog();
        }
    }
}
