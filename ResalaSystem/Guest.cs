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
                return _instance ;
            }
        }

        private void Guest_Load(object sender, EventArgs e)
        {

        }
    }
}
