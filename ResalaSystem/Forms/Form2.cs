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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private static Form2 _instance;

        public static Form2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form2();
                return _instance;
            }
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Instance.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
