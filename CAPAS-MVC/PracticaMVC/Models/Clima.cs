using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaMVC.Models
{
    public class Clima
    {
        public decimal lat { get; set; }
        public decimal lon { get; set; }
        public decimal alt_m { get; set; }
        public decimal alt_f { get; set; }
        public string wx_desc { get; set; }
        public int wx_code { get; set; }
        public string wx_icon { get; set; }
        public decimal temp_c { get; set; }
        public decimal temp_f { get; set; }
        public decimal feelslike_c { get; set; }
        public decimal feelslike_f { get; set; }
        public decimal windspd_mph { get; set; }
        public decimal windspd_kmh { get; set; }
        public decimal windspd_kts { get; set; }
        public decimal windspd_ms { get; set; }
        public decimal winddir_deg { get; set; }
        public string winddir_compass { get; set; }
        public decimal cloudtotal_pct { get; set; }
        public decimal humid_pct { get; set; }
        public decimal dewpoint_c { get; set; }
        public decimal dewpoint_f { get; set; }
        public decimal vis_km { get; set; }
        public decimal vis_mi { get; set; }
        public decimal slp_mb { get; set; }
        public decimal slp_in { get; set; }
    }
}