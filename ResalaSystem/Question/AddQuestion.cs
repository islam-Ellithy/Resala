using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ResalaSystem.Question
{
    public partial class AddQuestion : UserControl
    {

        private static AddQuestion _instance;

        public static AddQuestion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddQuestion();

                _instance.comboBox1.DataSource = BaseInfo.rtc.courses.ToList();
                _instance.comboBox1.DisplayMember = "course_name";

                return _instance;
            }
        }

        public AddQuestion()
        {
            InitializeComponent();
            comboBox1.DataSource = BaseInfo.rtc.courses.ToList();
            comboBox1.DisplayMember = "course_name";

        }


        public void addQuestions(string path)
        {
            string line = "";
            List<question> questions = new List<question>();


            using (StreamReader sr = new StreamReader(path))
            {
                question q = new question();
                choice c = new choice();
                answer a = new answer();
                int numOfChoices = 0;

                course crs = (from C in BaseInfo.rtc.courses
                                                  where C.course_name == comboBox1.Text
                                                  select C).ToList<course>()[0];
                q.course_id = crs.id;
                while (!sr.EndOfStream)
                {
                    q.id = BaseInfo.rtc.questions.Count() + 1;
                    q.question_desc = sr.ReadLine();
                    numOfChoices = Convert.ToInt32(sr.ReadLine());
                    for (int i = 0; i < numOfChoices; i++)
                    {
                        c.choice_desc = sr.ReadLine();
                        c.question_id = q.id;
                        q.choices.Add(c);

                        c = new choice();
                    }
                    a.question_id = q.id;
                    a.answer_desc = sr.ReadLine();

                    q.answers.Add(a);

                    questions.Add(q);

                    a = new answer();


                    q = new question();
                }
                BaseInfo.rtc.questions.AddRange(questions);
                BaseInfo.rtc.SaveChanges();

            }
            MessageBox.Show(line);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            addQuestions(path.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        OpenFileDialog file = new OpenFileDialog();
        private void button2_Click(object sender, EventArgs e)
        {
            if (file.ShowDialog() == DialogResult.OK)
            {
                path.Text = file.FileName;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
