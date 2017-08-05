using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResalaSystem.Question
{
    public partial class DeleteQuestion : UserControl
    {

        private static DeleteQuestion _instance;

        public static DeleteQuestion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DeleteQuestion();
            
                _instance.comboBox1.DataSource = BaseInfo.rtc.courses.ToList();
                _instance.comboBox1.DisplayMember = "course_name";

                return _instance;
            }
        }

        public DeleteQuestion()
        {
            InitializeComponent();
            comboBox1.DataSource = BaseInfo.rtc.courses.ToList();
            comboBox1.DisplayMember = "course_name";

        }

        private void DeleteQuestion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var course = (from C in BaseInfo.rtc.courses
                          where C.course_name == comboBox1.Text
                          select C).ToList<course>()[0];

            var questions = (from q in BaseInfo.rtc.questions
                             where q.course_id == course.id
                             select q).ToList();

            BaseInfo.rtc.questions.RemoveRange(questions);
            BaseInfo.rtc.SaveChanges();

            MessageBox.Show("تم حذف اسئلة الكورس بنجاح");
            
        }
    }
}
