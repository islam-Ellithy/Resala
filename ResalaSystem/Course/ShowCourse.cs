using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResalaSystem.Course
{
    public partial class ShowCourse : UserControl
    {
        public ShowCourse()
        {
            InitializeComponent();
            dataGridView1.DataSource = BaseInfo.rtc.courses.ToList();

        }


        private static ShowCourse _instance;

        public static ShowCourse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ShowCourse();

                _instance.dataGridView1.DataSource = BaseInfo.rtc.courses.ToList();

                return _instance;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.courseTableAdapter.FillBy(this.resalaDataSet.course);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
