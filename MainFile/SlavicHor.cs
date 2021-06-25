using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFile
{    

    public partial class SlavicHor : Form
    {
        public SlavH sh;

        public SlavicHor(SlavH sh)
        {
            InitializeComponent();
            this.sh = sh;
            SlavHo.Text = sh.god;
            SlavHo1.Text = sh.date;
            SlavHo2.Text = sh.abz1;
            SlavHo3.Text = sh.abz2;
        }

        private void SlavicHor_Load(object sender, EventArgs e)
        {

        }

        private void SlavHop_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
