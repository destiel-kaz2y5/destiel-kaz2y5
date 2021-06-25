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
    public partial class AnimalYear : Form
    {
        public Anim anim;

        public AnimalYear(Anim anim)
        {
            InitializeComponent();
            this.anim = anim;
            Animal.Text = anim.ani;
            Animal1.Text = anim.des;
        }

        private void Animal_Click(object sender, EventArgs e)
        {

        }

        private void Animal1_Click(object sender, EventArgs e)
        {

        }
    }
}
