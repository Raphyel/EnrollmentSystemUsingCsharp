using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mageenrollkaba
{
    public partial class Home : UserControl
    {
        public static Home _instance;
        public static Home instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Home();
                return _instance;
            }

        }

        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
