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
    public partial class SettingsView : Form, ISettingsView, ISettingsPresenter
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


        public event Delegates.GoToScenario GoToScenario;

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

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

    }
}
