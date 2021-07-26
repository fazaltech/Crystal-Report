using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CR_Viewer.Model
{
    [Table("bio_info")]
    public partial class bio_info
    {
        public int id { get; set; }
        public string name { get; set; }
        public string father_name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string dob { get; set; }
        public string doa { get; set; }
    }
}