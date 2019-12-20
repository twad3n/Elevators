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
    public partial class MainView : Form, IMainView, IMainPresenter
    {
        private readonly ApplicationContext _context;
        public MainView(ApplicationContext context)
        {
            _context = context;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(1024, 768);
            this.MaximumSize = new Size(1024, 768);
            InitializeComponent();
        }


        public event Delegates.GoToSettings GoToSettings;

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void openSettingsButton_Click(object sender, EventArgs e)
        {
            GoToSettings?.Invoke();
        }
    }
}
