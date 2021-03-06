﻿using Elevators.Presenters;
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
    public partial class ScenarioView : Form, IScenarioView
    {
        private ApplicationContext _context;
        public ScenarioView(ApplicationContext context)
        {
            _context = context;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimumSize = new Size(400, 500);
            this.MaximumSize = new Size(400, 500);
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

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void ScenarioView_Load(object sender, EventArgs e)
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

        private void applyScenarioButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
