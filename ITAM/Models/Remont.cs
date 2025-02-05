using System;

namespace ITAM.Models
{
    public class Remont
    {
        public int ID_IT { get; set; }
        public DateTime DATA_REMONTA { get; set; }
        public string OPIS_PROBL { get; set; }
        public double? STOIM_REM { get; set; }
        public string TIP_REMONTA { get; set; }

    }
}