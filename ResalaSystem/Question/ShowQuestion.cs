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
    public partial class ShowQuestion : UserControl
    {
        private static ShowQuestion _instance;

        public static ShowQuestion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShowQuestion();

                _instance.dataGridView1.DataSource = BaseInfo.rtc.questions.ToList();

                _instance.dataGridView2.DataSource = BaseInfo.rtc.choices.ToList();

                _instance.dataGridView3.DataSource = BaseInfo.rtc.answers.ToList();

                return _instance;
            }
        }

        public ShowQuestion()
        {
            InitializeComponent();
            updateDataGrid();
        }

        private void updateDataGrid()
        {
            dataGridView1.DataSource = BaseInfo.rtc.questions.ToList();

            dataGridView2.DataSource = BaseInfo.rtc.choices.ToList();

            dataGridView3.DataSource = BaseInfo.rtc.answers.ToList();

            
        }

        private void UpdateQuestion_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
