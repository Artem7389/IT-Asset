using System;

namespace ITAM.Models
{
    public class Oborudovanie
    {
        public int ID_IT { get; set; }
        public string NAZV_OBORUD { get; set; }
        public string MODEL { get; set; }
        public int KATEG {get; set;}
        public string SER_NOMER { get; set; }
        public string INV_NOMER { get; set; }
        public int MAT_OTV { get; set; }
        public string RASPOL { get; set; }
        public DateTime? DATA_POL { get; set; }
        public DateTime? VIVOD_EKSP { get; set; }
    }
}