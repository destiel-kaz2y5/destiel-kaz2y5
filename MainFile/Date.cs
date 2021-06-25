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
    public partial class Date : Form
    {
        public Dates dates;

        public Date(Dates dates)
        {
            InitializeComponent();
            this.dates = dates;
            ComDat.Text = dates.day;
            ComDat1.Text = dates.january;
            ComDat2.Text = dates.february;
            ComDat3.Text = dates.march;
            ComDat4.Text = dates.april;
            ComDat5.Text = dates.may;
            ComDat6.Text = dates.june;
            ComDat7.Text = dates.july;
            ComDat8.Text = dates.august;
            ComDat9.Text = dates.september;
            ComDat10.Text = dates.october;
            ComDat11.Text = dates.november;
            ComDat12.Text = dates.december;           
        }

        private void Date_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
