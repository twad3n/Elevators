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
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(1024, 768);
            this.MaximumSize = new Size(1024, 768);
            InitializeComponent();
        }



        public new void Show()
        {
            Application.Run(this);
        }
    }
}
