using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ednevnik410b
{
    public partial class Upisnica : Form
    {
        public Upisnica()
        {
            InitializeComponent();
        }

        private void Upisnica_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
