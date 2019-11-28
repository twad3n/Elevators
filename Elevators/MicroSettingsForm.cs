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
    public partial class MicroSettingsForm : Form
    {
        public MicroSettingsForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(400, 500);
            this.MaximumSize = new Size(400, 500);
            InitializeComponent();
        }

        private void MicroSettingsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1");
            dataGridView1.Rows.Add("2");
            dataGridView1.Rows.Add("3");
            dataGridView1.Rows.Add("4");
            dataGridView1.Rows.Add("5");
            dataGridView1.Rows.Add("6");
            dataGridView1.Rows.Add("7");
            dataGridView1.Rows.Add("8");
            dataGridView1.Rows.Add("9");
            dataGridView1.Rows.Add("10");
            dataGridView1.Rows.Add("11");
            dataGridView1.Rows.Add("12");
            dataGridView1.Rows.Add("13");
            dataGridView1.Rows.Add("14");
            dataGridView1.Rows.Add("15");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
