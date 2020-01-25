using Elevators.Models.Repositories;
using Elevators.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevators.Views
{
    public partial class SettingsView : Form, ISettingsView
    {
        private ApplicationContext _context;

        public SettingsView(ApplicationContext context)
        {
            _context = context;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(640, 380);
            this.MaximumSize = new Size(640, 380);
            InitializeComponent();
        }


        public event Action GoToScenario;
        public event Action ApplySettings;
        public event Action<int, int> SettingsChanged;
        public event Action<string> ImportSettings;
        public event Action<string> ExportSettings;

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GoToScenario?.Invoke();
            //Form formMicroSettings = new MicroSettingsView();
            //formMicroSettings.ShowDialog();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        public void Save()
        {

        }
        public void Discard()
        {

        }
        public void Import()
        {

        }
        public void Export()
        {

        }

        private void importSettingsButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportSettings?.Invoke(openFileDialog.FileName);
            }
        }

        private void exportSettingsButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportSettings?.Invoke(saveFileDialog.FileName);
            }
        }

        private void applySettings_Click(object sender, EventArgs e)
        {
            ApplySettings?.Invoke();
        }


        int floors = 0;
        int elevators = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out floors))
            {
                MessageBox.Show("ok");
            };
            int.TryParse(textBox2.Text, out elevators);

            //int.TryParse(textBox1.Text, out floors);
            //int.TryParse(textBox2.Text, out elevators);
            SettingsChanged?.Invoke(floors, elevators);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out floors);
            int.TryParse(textBox2.Text, out elevators);

            //Int32.TryParse(textBox1.Text, out floors);
            //Int32.TryParse(textBox2.Text, out elevators);
            SettingsChanged?.Invoke(floors, elevators);

        }
    }
}
