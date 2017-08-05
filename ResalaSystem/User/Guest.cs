using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResalaSystem
{
    public partial class Guest : UserControl
    {

        public Guest()
        {
            InitializeComponent();
        }


        private static Guest _instance;

        public static Guest Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Guest();
                }
                return _instance;
            }
        }

        private void Guest_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            this.ParentForm.Hide();
            Form2.Instance.Show();

            //f

            //this.ParentForm.Controls.Add(GuestExam.Instance);
            //GuestExam.Instance.Dock = DockStyle.Fill;

            /*            if (!this.FindForm().panelMain.Controls.Contains(Teacher.Instance))
                        {
                            panelMain.Controls.Add(Teacher.Instance);
                            Teacher.Instance.Dock = DockStyle.Fill;
                        }
              */
            //Form2 f = new Form2();
            //f.Show();
            //f.Controls.Remove(Guest.Instance);

//            f.Controls.Add(GuestExam.Instance);
        }
    }
}
