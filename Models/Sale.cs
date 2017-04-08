using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp_net_core_mvc_mysql_dashboard.Models {

    public class Sale{
        public int id { get; set; }
        public DateTime date  { get; set; }
        public string product { get; set; }
        public double price { get; set; }
        public int count { get; set; }
        public string region { get; set; }
    }

}