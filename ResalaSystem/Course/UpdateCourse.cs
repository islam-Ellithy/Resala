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
    public partial class UpdateCourse : UserControl
    {
        int id;
        public UpdateCourse()
        {
            InitializeComponent();
            comboBox1.DataSource = BaseInfo.rtc.courses.ToList();
            comboBox1.DisplayMember = "course_name";
           


        }


        private static UpdateCourse _instance;

        public static UpdateCourse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UpdateCourse();

                _instance.comboBox1.DataSource = BaseInfo.rtc.courses.ToList();

                return _instance;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string newName = new_course_name.Text;

            string oldName = comboBox1.Text;

            newName = newName.Trim();
            if (newName.Length > 0)
            {

                try
                {
                    
                

                     var UpdatedCourse = (from C in BaseInfo.rtc.courses
                                          where C.course_name == oldName
                                          select C).ToList<course>()[0];

                    UpdatedCourse.course_name = newName;

                    BaseInfo.rtc.SaveChanges();

                    _instance.comboBox1.DataSource = BaseInfo.rtc.courses.ToList();

                    new_course_name.Clear();

                    MessageBox.Show("تم تعديل الكورس");

                    
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }
    }
}
