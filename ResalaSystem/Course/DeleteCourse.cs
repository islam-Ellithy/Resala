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
    public partial class DeleteCourse : UserControl
    {
        public DeleteCourse()
        {
            InitializeComponent();
            updateCombo();
        }


        private static DeleteCourse _instance;

        public static DeleteCourse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DeleteCourse();

                _instance.comboBox1.DataSource = BaseInfo.rtc.courses.ToList();
                _instance.comboBox1.DisplayMember = "course_name";

                return _instance;
            }
        }
        private void DeleteCourse_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void updateCombo()
        {
            comboBox1.DataSource = BaseInfo.rtc.courses.ToList();
            comboBox1.DisplayMember = "course_name";

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            BaseInfo.DeleteCourse(comboBox1.Text);
            updateCombo();


            MessageBox.Show("تم حذف الكورس بنجاح");

        }
    }
}
