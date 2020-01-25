using Elevators.Models;
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
    public partial class MainView : Form, IMainView
    {
        private readonly ApplicationContext _context;
        public MainView(ApplicationContext context)
        {
            _settings = new Settings();
            _settings.numberOfElevators = 1;
            _settings.numberOfFloors = 1;
            _context = context;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(1024, 768);
            this.MaximumSize = new Size(1024, 768);
            InitializeComponent();
        }

        //private List<Button> floorsIconsArray = new List<Button>(5);
        //private List<PictureBox> elevatorsIconsArray = new List<PictureBox>(5);
        private Settings _settings;
        private int x;
        private int y;
        private int height;


        public event Action GoToSettings;
        public event Action Start;
        public event Action Pause;
        public event Action Stop;
        public event Action AddMan;
        public event Action MoveUpABit;
        public event Action MoveDownABit;

        public new void Show()
        {
            _context.MainForm = this;
            InitializeScene();
            base.Show();
        }

        public void GetSettings(Settings settings)
        {
            _settings = settings;
        }

        private void InitializeScene()
        {
            field.SendToBack();
            x = field.Location.X - 80;
            y = field.Location.Y + field.Size.Height;
            height = field.Size.Height / _settings.numberOfFloors;

            for (int i = 0; i < _settings.numberOfElevators; i++)
            {
                PictureBox elevatorPic = new PictureBox();
                elevatorPic.Image = elevator.Image;
                elevatorPic.SizeMode = PictureBoxSizeMode.Zoom;
                elevatorPic.Size = new Size(100, height);
                elevatorPic.Location = new Point(x + 80 + (i * 140), y - height);
                
                Controls.Add(elevatorPic);

            }

                for (int i = 0; i < _settings.numberOfFloors; i++)
            {
                Button floorBtn = new Button();
                floorBtn.Font = floorIconBase.Font;
                floorBtn.Size = new Size(50, height);
                floorBtn.Location = new Point(x, y - (i + 1) * height);
                floorBtn.BackColor = Color.White;
                floorBtn.Enabled = false;
                floorBtn.Text = (i + 1).ToString();
                Controls.Add(floorBtn);
            }
        }


        public void _AddMan(Man man)
        {
            PictureBox manPic = new PictureBox();
            manPic.Image = pictureMan.Image;
            manPic.SizeMode = PictureBoxSizeMode.Zoom;
            manPic.Size = new Size(100, height);
            manPic.Location = new Point(x + 80, y - height);

            Controls.Add(manPic);
        }

        public void _MoveUpElevator()
        {
            foreach (var c in Controls.OfType<PictureBox>())
            {
                if (c.Image == elevator.Image && c.Location.Y > field.Location.Y + 4) 
                    c.Location = new Point(c.Location.X, c.Location.Y - field.Size.Height / _settings.numberOfFloors);
            }
        }

        public void _MoveDownElevator()
        {
            foreach (var c in Controls.OfType<PictureBox>())
            {
                if (c.Image == elevator.Image && c.Location.Y < field.Location.Y + field.Height - height)
                    c.Location = new Point(c.Location.X, c.Location.Y + field.Size.Height / _settings.numberOfFloors);
            }
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

        private void dontClickMe_Click(object sender, EventArgs e)
        {
            MoveDownABit?.Invoke();
        }
    }
}
