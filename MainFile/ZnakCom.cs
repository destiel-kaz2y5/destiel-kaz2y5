using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
namespace MainFile
{
    public partial class ZnakCom : Form
    {
        string s = "";

        Task task;
        string z1, z2;
        public ZnakCom()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            richTextBox1.Text = s;
        }
        string Translite(int id)
        {
            string result = "";
            switch (id)
            {
                case 0:
                    result = "oven";
                    break;
                case 1:
                    result = "telets";
                    break;
                case 2:
                    result = "bliznecy";
                    break;
                case 3:
                    result = "rak";
                    break;
                case 4:
                    result = "lev";
                    break;
                case 5:
                    result = "deva";
                    break;
                case 6:
                    result = "vesy";
                    break;
                case 7:
                    result = "skorpion";
                    break;
                case 8:
                    result = "strelets";
                    break;
                case 9:
                    result = "kozerog";
                    break;
                case 10:
                    result = "vodoley";
                    break;
                case 11:
                    result = "riby";
                    break;
            }
            return result; 
        }

        void SetData()
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            try
            {
                var htmlDoc = htmlWeb.Load("http://in-contri.ru/sovmestimost-znakov-zodiaka/" + z1 + "/" + z2 + "/");
                var contentPageHoro = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='content-page-horo']");
                var h2 = contentPageHoro.SelectSingleNode("//h2[1]");
                var p1 = contentPageHoro.SelectSingleNode("//p[1]");
                var p2 = contentPageHoro.SelectSingleNode("//p[2]");
                var p3 = contentPageHoro.SelectSingleNode("//p[3]");
                var p4 = contentPageHoro.SelectSingleNode("//p[4]");
                var p5 = contentPageHoro.SelectSingleNode("//p[5]");
                var p6 = contentPageHoro.SelectSingleNode("//p[6]");
                s = h2.InnerText + "\n" + p1.InnerText + "\n" + p2.InnerText + "\n" + p3.InnerText + "\n" + p4.InnerText + "\n" + p5.InnerText + "\n" + p1.InnerText;
            }
            catch (Exception e)
            {
                s = "Нет соединения. Подключитесь к сети и попробуйте снова!";
            }
        }
        private void ZnakCom_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            task.Wait();
            richTextBox1.Text = s;
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            z1 = Translite(comboBox1.SelectedIndex);
            z2 = Translite(comboBox2.SelectedIndex);            
            task = new Task(SetData);
            task.Start();
            richTextBox1.Text = "Обработка данных";
            timer1.Start();
            
        }
    }
}
