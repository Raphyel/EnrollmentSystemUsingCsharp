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
    public partial class Event : UserControl
    {

        public static Event _instance;
        public static Event instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Event();
                return _instance;
            }

        }

        public Event()
        {
            InitializeComponent();
        }
    }
}
