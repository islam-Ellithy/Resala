using ResalaSystem.Course;
using ResalaSystem.Question;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResalaSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private static Form3 _instance;

        public static Form3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form3();
                return _instance;
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Instance.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(AddCourse.Instance))
            {
                panel2.Controls.Add(AddCourse.Instance);
                AddCourse.Instance.Dock = DockStyle.Fill;
            }

            AddCourse.Instance.BringToFront();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(UpdateCourse.Instance))
            {
                panel2.Controls.Add(UpdateCourse.Instance);
                UpdateCourse.Instance.Dock = DockStyle.Fill;
            }

            UpdateCourse.Instance.BringToFront();

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(DeleteCourse.Instance))
            {
                panel2.Controls.Add(DeleteCourse.Instance);
                DeleteCourse.Instance.Dock = DockStyle.Fill;
            }

            DeleteCourse.Instance.BringToFront();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (!panel6.Controls.Contains(ShowQuestion.Instance))
            {
                panel6.Controls.Add(ShowQuestion.Instance);
                ShowQuestion.Instance.Dock = DockStyle.Fill;
            }

            ShowQuestion.Instance.BringToFront();


        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            if (!panel6.Controls.Contains(DeleteQuestion.Instance))
            {
                panel6.Controls.Add(DeleteQuestion.Instance);
                DeleteQuestion.Instance.Dock = DockStyle.Fill;
            }

            DeleteQuestion.Instance.BringToFront();

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            if (!panel6.Controls.Contains(AddQuestion.Instance))
            {
                panel6.Controls.Add(AddQuestion.Instance);
                AddCourse.Instance.Dock = DockStyle.Fill;
            }

            AddQuestion.Instance.BringToFront();

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        } 

        private void bunifuFlatButton12_Click_1(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ShowCourse.Instance))
            {
                panel2.Controls.Add(ShowCourse.Instance);
                ShowCourse.Instance.Dock = DockStyle.Fill;
            }

            ShowCourse.Instance.BringToFront();
           
        }
    }
}