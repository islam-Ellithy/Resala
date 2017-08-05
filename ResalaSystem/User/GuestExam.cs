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
    public partial class GuestExam : UserControl
    {
        public GuestExam()
        {
            InitializeComponent();
        }

        private static GuestExam _instance;

        public static GuestExam Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GuestExam();

                return _instance;
            }
        }

        private void GuestExam_Load(object sender, EventArgs e)
        {

        }
    }
}
