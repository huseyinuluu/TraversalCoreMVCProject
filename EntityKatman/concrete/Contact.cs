﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatman.concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Maplocation { get; set; }
        public bool Status { get; set; }
    }
}
