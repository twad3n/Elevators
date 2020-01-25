using Elevators.Models;
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
    public partial class MainView : Form, IMainView
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

        private int numberOfFloors = 4;
        private int numberOfElevators = 1;
        private List<Button> floorsIconsArray = new List<Button>(5);
        private List<PictureBox> elevatorsIconsArray = new List<PictureBox>(5);

        public event Action GoToSettings;
        public event Action Start;
        public event Action Pause;
        public event Action Stop;
        public event Action AddMan;
        public event Action MoveUpABit;

        public new void Show()
        {
            _context.MainForm = this;
            InitializeScene();
            base.Show();
        }

        private void InitializeScene()
        {
            int x = field.Location.X - 80;
            int y = field.Location.Y + field.Size.Height;
            int height = field.Size.Height / numberOfFloors;

            for (int i = 0; i < numberOfElevators; i++)
            {
                PictureBox elevatorPic = new PictureBox();
                elevatorPic.BackgroundImage = elevator.BackgroundImage;
                elevatorPic.Size = new Size(100, height);
                elevatorPic.Location = new Point(x + 30 + (i * 40), y - height);
                Controls.Add(elevatorPic);

            }

                for (int i = 0; i < numberOfFloors; i++)
            {
                Button floorBtn = new Button();
                floorBtn.Font = floorIconBase.Font;
                floorBtn.Size = new Size(50, height);
                floorBtn.Location = new Point(x, y - (i + 1) * height);
                floorBtn.BackColor = Color.White;
                floorBtn.Enabled = false;
                floorBtn.Text = (i + 1).ToString();
                floorsIconsArray.Add(floorBtn);
                Controls.Add(floorBtn);
            }
        }



        public void _MoveUpElevator()
        {
            elevator.Location = new Point(elevator.Location.X, elevator.Location.Y - 80);
        }

        private void openSettingsButton_Click(object sender, EventArgs e)
        {
            GoToSettings?.Invoke();
        }

        private void addManButton_Click(object sender, EventArgs e)
        {
            AddMan?.Invoke();
        }

        private void clickMe_Click(object sender, EventArgs e)
        {
            MoveUpABit?.Invoke();
        }
    }
}
