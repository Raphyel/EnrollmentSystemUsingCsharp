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
    public partial class contactUs : UserControl
    {
        public static contactUs _instance;
        public static contactUs instance
        {
            get
            {
                if (_instance == null)
                    _instance = new contactUs();
                return _instance;
            }

        }

        public contactUs()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
