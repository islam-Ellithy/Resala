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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            indicator.Left = 0;
        }

        private static Form1 _instance ;

        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }

        private void setTap(Object sender)
        {
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;
        }
        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            setTap(sender);
            if(!panelMain.Controls.Contains(Teacher.Instance))
            {
                panelMain.Controls.Add(Teacher.Instance);
                Teacher.Instance.Dock = DockStyle.Fill;
            }

            Teacher.Instance.BringToFront();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            setTap(sender);

            if (!panelMain.Controls.Contains(Guest.Instance))
            {
                panelMain.Controls.Add(Guest.Instance);
                Guest.Instance.Dock = DockStyle.Fill;
            }

            Guest.Instance.BringToFront();

        }
        

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
