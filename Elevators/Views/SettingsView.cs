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

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public event Action GoToScenario;
        public event Action ApplySettings;
        public event Action<int, int> SettingsChanged;
        public event Action<string> ImportSettings;
        public event Action<string> ExportSettings;
        public event Action SettingsUpdated;

        public void UpdateSettingsField(Settings settings)
        {
            try
            {
                textBox1.Text = Convert.ToString(settings.numberOfFloors);
                textBox1.Text = settings.numberOfFloors.ToString();
                textBox2.Text = Convert.ToString(settings.numberOfElevators);
                textBox2.Text = settings.numberOfElevators.ToString();
            }
            catch (Exception exept)
            {
                MessageBox.Show("oshibka");
            }
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GoToScenario?.Invoke();
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
                SettingsUpdated?.Invoke();
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
            int.TryParse(textBox1.Text, out floors);
            int.TryParse(textBox2.Text, out elevators);

            if (floors <= 5 && floors >= 1)
            {
                SettingsChanged?.Invoke(floors, elevators);
            }
            else
            {
                MessageBox.Show("numbers of floors and elevators must be in the range of [1; 5]");
                textBox1.Text = Convert.ToString(1);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out floors);
            int.TryParse(textBox2.Text, out elevators);

            if (elevators <= 5 && elevators >= 1)
            {
                SettingsChanged?.Invoke(floors, elevators);
            }
            else
            {
                MessageBox.Show("numbers of floors and elevators must be in the range of [1; 5]");
                textBox2.Text = Convert.ToString(1);
            }
        }
    }
}
