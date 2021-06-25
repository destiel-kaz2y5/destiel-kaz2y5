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
    public partial class Form4 : Form
    {
        public DruidH drui;

        public Form4(DruidH drui)
        {
            InitializeComponent();
            this.drui = drui;
            DruiHo.Text = drui.plant;
            DruiHo1.Text = drui.range;
            DruiHo2.Text = drui.desc1;
            DruiHo3.Text = drui.desc2;
            DruiHo4.Text = drui.desc3;
            DruiHo5.Text = drui.desc4;
            DruiHo6.Text = drui.desc5;

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
