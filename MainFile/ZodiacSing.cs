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
    public partial class Form2 : Form
    {
        public ZodSing zodiacSing;
        public Form2(ZodSing zodiacSing)
        {
            InitializeComponent();

            this.zodiacSing = zodiacSing;
            Zodiac.Text = zodiacSing.zod;
            Zodiac1.Text = zodiacSing.elem;
            Zodiac2.Text = zodiacSing.qual;
            Zodiac3.Text = zodiacSing.col;
            Zodiac4.Text = zodiacSing.day;
            Zodiac5.Text = zodiacSing.plan;
            Zodiac6.Text = zodiacSing.maxcom;
            Zodiac7.Text = zodiacSing.hapday;
            Zodiac8.Text = zodiacSing.range;
            Zodiac9.Text = zodiacSing.descSil;
            Zodiac10.Text = zodiacSing.descSlab;
            Zodiac11.Text = zodiacSing.descL;
            Zodiac12.Text = zodiacSing.descNl;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Zodiac9_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac10_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac12_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac8_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac4_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac7_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac6_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac5_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac3_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac2_Click(object sender, EventArgs e)
        {

        }

        private void Zodiac1_Click(object sender, EventArgs e)
        {

        }
    }
}
