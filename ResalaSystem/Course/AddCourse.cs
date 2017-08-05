using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResalaSystem.Course;

namespace ResalaSystem
{
    public partial class AddCourse : UserControl
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private static AddCourse _instance;

        public static AddCourse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddCourse();
                return _instance;
            }
        }
        private void AddCourse_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            using (resalaEntities1 context = new resalaEntities1())
            {
                try
                {

                    course c = new course()
                    {
                        course_name = course_name.Text,
                        course_description = course_desc.Text

                    };

                    context.courses.Add(c);

                    context.SaveChanges();
                    /*
                                        if (!panel2.Controls.Contains(ShowCourse.Instance))
                                        {
                                            panel2.Controls.Add(ShowCourse.Instance);
                                            ShowCourse.Instance.Dock = DockStyle.Fill;
                                        }

                                        ShowCourse.Instance.BringToFront();
                                        */
                    course_name.Clear();
                    course_desc.Clear();
                    MessageBox.Show("Data has saved/display successfully");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
