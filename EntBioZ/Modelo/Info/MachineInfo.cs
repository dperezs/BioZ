﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntBioZ.Modelo.Info
{
    public class MachineInfo
    {

        public int MachineNumber { get; set; }
        public int IndRegID { get; set; }
        public string DateTimeRecord { get; set; }

        public DateTime DateOnlyRecord
        {
            get { return DateTime.Parse(DateTime.Parse(DateTimeRecord).ToString("yyyy-MM-dd")); }
        }
        public DateTime TimeOnlyRecord
        {
            get { return DateTime.Parse(DateTime.Parse(DateTimeRecord).ToString("hh:mm:ss tt")); }
        }
        public string sDateOnlyRecord
        {
            get { return DateTime.Parse(DateTimeRecord).ToString("yyyy-MM-dd"); }
        }
        public string sTimeOnlyRecord
        {
            get { return DateTime.Parse(DateTimeRecord).ToString("hh:mm:ss tt"); }
        }

    }
}
