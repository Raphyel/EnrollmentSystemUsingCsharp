using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mageenrollkaba
{
    public partial class AccountingBSITStudent : Form
    {
        public AccountingBSITStudent(string msg)
        {
            InitializeComponent();
            label1.Text = msg;
        }
    }
}
