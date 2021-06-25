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
    
    public partial class Form1 : Form
    {
        public int kodz;
        public int ye;
        public int dat;
        public int sl;
        public int dri;
        public List<ZodSing> zodiacSings;
        public List<Anim> anims;
        public List<Dates> date;
        public List<SlavH> slah;
        public List<DruidH> druid;
        public List<HoroscopAll> druidran;

        List<T> GetList<T>(string file)
        {
            if (!System.IO.File.Exists(file))
                MessageBox.Show("Файл "+file+"  не найден. \n Программа отказывается работать корректно.");
            else
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(file);
                string data = streamReader.ReadToEnd();
                streamReader.Close();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(data);
            }
            return null;
        }

        public Form1()
        {
            InitializeComponent();


            zodiacSings = GetList<ZodSing>("zz.txt");
            ZnakZod.Enabled = zodiacSings != null;
            anims = GetList<Anim>("an.txt");
            YearChi.Enabled = anims != null;
            date = GetList<Dates>("da.txt");
            DateH.Enabled = date != null;
            slah = GetList<SlavH>("sl.txt");
            SlavBut.Enabled = slah != null;
            druid = GetList<DruidH>("dr.txt");
            DruidBut.Enabled = druid != null;
            //System.IO.StreamReader streamReader = new System.IO.StreamReader("zz.txt");
            //zodiacSings = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ZodSing>>(streamReader.ReadToEnd());
            //streamReader.Close();            

            DataHap.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DataHap_ValueChanged(object sender, EventArgs e)
        {
                       
        }

        private void ZnakZod_Click(object sender, EventArgs e)
        {
            //druidran.ForEach(x => {if (x.CheckData(date)) dri = x.index;});  
            { //ZodiacSing zodiacSing = new ZodiacSing();
              //zodiacSing.zod = "Овен";
              //zodiacSing.elem = "Огонь";
              //zodiacSing.qual = "Кардинальное";
              //zodiacSing.col = "Красный";
              //zodiacSing.day = "Вторник";
              //zodiacSing.plan = "Марс";
              //zodiacSing.maxcom = "Весы, Лев";
              //zodiacSing.hapday = "1, 8, 17";
              //zodiacSing.range = "21 марта — 19 апреля";
              //zodiacSing.descSil = "Сильный стороны тото";
              //zodiacSing.descSlab = "Слабые стороны тото";
              //zodiacSing.descS = "Остальное";
              //List<ZodiacSing> zodiacSings = new List<ZodiacSing>();
              //zodiacSings.Add(zodiacSing);
              //System.IO.StreamWriter streamWriter = new System.IO.StreamWriter("zz.txt");
              //streamWriter.Write(Newtonsoft.Json.JsonConvert.SerializeObject(zodiacSings));
              //streamWriter.Close();
            }
            //DateTime date = new DateTime(2020, DataHap.Value.Month, DataHap.Value.Day);
            //kodz = -1;
            //for (int i = 0; i < druidran.Count && kodz == -1; i++)
            //{
            //    if (druidran[i].CheckData(date))
            //    {
            //        kodz = druidran[i].index;
            //    }
            //}
            int d = DataHap.Value.Day;
            int m = DataHap.Value.Month;       
            
            switch (m) // ищем знак зодиака и присваиваем код
            {
                case 1:
                    {
                        if (d >= 1 && d <= 20) kodz = 10;
                        else kodz = 11;
                        break;
                    }
                case 2:
                    {
                        if (d >= 1 && d <= 19) kodz = 11;
                        else kodz = 12;
                        break;
                    }
                case 3:
                    {
                        if (d >= 1 && d <= 20) kodz = 12;
                        else kodz = 1;
                        break;
                    }
                case 4:
                    {
                        if (d >= 1 && d <= 20) kodz = 1;
                        else kodz = 2;
                        break;
                    }
                case 5:
                    {
                        if (d >= 1 && d <= 21) kodz = 2;
                        else kodz = 3;
                        break;
                    }
                case 6:
                    {
                        if (d >= 1 && d <= 21) kodz = 3;
                        else kodz = 4;
                        break;
                    }
                case 7:
                    {
                        if (d >= 1 && d <= 22) kodz = 4;
                        else kodz = 5;
                        break;
                    }
                case 8:
                    {
                        if (d >= 1 && d <= 21) kodz = 5;
                        else kodz = 6;
                        break;
                    }
                case 9:
                    {
                        if (d >= 1 && d <= 23) kodz = 6;
                        else kodz = 7;
                        break;
                    }
                case 10:
                    {
                        if (d >= 1 && d <= 23) kodz = 7;
                        else kodz = 8;
                        break;
                    }
                case 11:
                    {
                        if (d >= 1 && d <= 22) kodz = 8;
                        else kodz = 9;
                        break;
                    }
                case 12:
                    {
                        if (d >= 1 && d <= 22) kodz = 9;
                        else kodz = 10;
                        break;
                    }
            }
            ZodSing zodiacSing = zodiacSings[kodz-1];
            Form2 form2 = new Form2(zodiacSing);
            form2.ShowDialog();
        }

        private void YearChi_Click(object sender, EventArgs e)
        {
            ye = DataHap.Value.Year % 12;
            Anim anim = anims[ye];
            AnimalYear form3 = new AnimalYear(anim);
            form3.ShowDialog();
        }
                
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SlavBut_Click(object sender, EventArgs e)
        {
            druidran = GetList<HoroscopAll>("slRan.txt");
            if (druidran == null) return;
            DateTime date = new DateTime(2020, DataHap.Value.Month, DataHap.Value.Day);
            sl = -1;
            for (int i = 0; i < druidran.Count && sl == -1; i++)
            {
                if (druidran[i].CheckData(date))
                {
                    sl = druidran[i].index;
                    
                }
            }
            if (sl != -1)
            {
                SlavH slavc = slah[sl];
                SlavicHor slav = new SlavicHor(slavc);
                slav.ShowDialog();
            }
            else MessageBox.Show("Данные в файле slRan.txt были повреждены. \n Программа отказывается работать корректно.");
        }

        private void DruidBut_Click(object sender, EventArgs e)
        {
            druidran = GetList<HoroscopAll>("drRan.txt");
            if (druidran == null) return;
            DruidBut.Enabled = druidran != null;
            DateTime date = new DateTime(2020, DataHap.Value.Month, DataHap.Value.Day);
            dri = -1;
            for (int i = 0; i < druidran.Count && dri == -1; i++)
            {
                if (druidran[i].CheckData(date))
                {
                    dri = druidran[i].index;
                }
            }
            if (dri != -1)
            {
                DruidH dru = druid[dri];
                Form4 form4 = new Form4(dru);
                form4.ShowDialog();
            }
            else  MessageBox.Show("Данные в файле drRan.txt были повреждены. \n Программа отказывается работать корректно.");
        }

        private void DateH_Click(object sender, EventArgs e)
        {
             if (DateTime.IsLeapYear(DataHap.Value.Year) || DataHap.Value.DayOfYear <= 59)
             {
                 dat = DataHap.Value.DayOfYear - 1;
             }
             else
             {
                dat = DataHap.Value.DayOfYear;
             }
            Dates da = date[dat];
            Date dates = new Date(da);
            dates.ShowDialog();            
        }

        private void ZodCom_Click(object sender, EventArgs e)
        {
            ZnakCom znakCom = new ZnakCom();
            znakCom.ShowDialog();
        }
    }
}
