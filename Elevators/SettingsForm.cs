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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(640, 380);
            this.MaximumSize = new Size(640, 380);
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form formMicroSettings = new MicroSettingsForm();
            formMicroSettings.ShowDialog();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
