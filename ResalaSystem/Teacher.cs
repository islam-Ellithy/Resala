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
    public partial class Teacher : UserControl
    {
        public Teacher()
        {
            InitializeComponent();
        }
        private static Teacher _instance;

        public static Teacher Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Teacher();
                }
                return _instance;
            }
        }
        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
