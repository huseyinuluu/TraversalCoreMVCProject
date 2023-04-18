﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatman.concrete
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayTimes { get; set; }       
        public double Price { get; set; }       
        public string Image { get; set; }
        public string Descriptions { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        public string CoverImage { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string Image2 { get; set; }
        public DateTime Date { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Visit> Visits { get; set; }
        public int? GuideID { get; set; }
        public Guide Guide { get; set; }
    }
    
}
