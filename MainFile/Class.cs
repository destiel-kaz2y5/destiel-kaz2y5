using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainFile
{
    public class ZodSing
    {
        public string zod;
        public string elem;
        public string qual;
        public string col;
        public string day;
        public string plan;
        public string maxcom;
        public string hapday;
        public string range;
        public string descSil;
        public string descSlab;
        public string descL;
        public string descNl;
    }

    public class Anim
    {
        public string ani;
        public string des;
    }

    public class SlavH
    {
        public string god;
        public string date;
        public string abz1;
        public string abz2;
    }

    public class DruidH
    {
        public string plant;
        public string range;
        public string desc1;
        public string desc2;
        public string desc3;
        public string desc4;
        public string desc5;
    }

    public class Dates
    {
        public string day;
        public string january;
        public string february;
        public string march;
        public string april;
        public string may;
        public string june;
        public string july;
        public string august;
        public string september;
        public string october;
        public string november;
        public string december;
    }

    public class Range
    {
        public DateTime nachalo;
        public DateTime konec;
    }
    public class HoroscopAll
    {
        public List<Range> Ranges;
        public int index;
        public bool CheckData(DateTime date) {
            
            Range Range = null;
            for (int i = 0; i < Ranges.Count && Range == null; i++)
            {
                if (Ranges[i].nachalo <= date && Ranges[i].konec >= date)
                    Range = Ranges[i];

            }
            return Range != null;
          //return  druidRanges.Find(d => { return d.nachalo < date && d.konec > date; })!=null;
        }
    }
}
