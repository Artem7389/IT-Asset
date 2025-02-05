using System;

namespace ITAM.Models
{
    public class Sotrudnik
    {
        public int MAT_OTV { get; set; }
        public string IMYA { get; set; }
        public string DOLZHNOST { get; set; }
        public string NOMER_TEL { get; set; }
        public string ELEKTR_POCHTA { get; set; }
        public DateTime? DATA_NAYMA { get; set; }
        public DateTime? DATA_UVOL { get; set; }
        public DateTime? DATA_ROZHD { get; set; }

    }
}