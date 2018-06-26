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
    public partial class About : UserControl
    {
        public static About _instance;
        public static About instance
        {
            get
            {
                if (_instance == null)
                    _instance = new About();
                return _instance;
            }

        }


        public About()
        {
            InitializeComponent();
        }
    }
}
