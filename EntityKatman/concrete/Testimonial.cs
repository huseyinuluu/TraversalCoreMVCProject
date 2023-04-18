using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatman.concrete
{
    public class Testimonial
    {
        [Key]
        // Referanslar
        public int TestimonialID { get; set; }
        // Müşteri ID
        public string Client { get; set; }
        // Müşteri
        public string Comment { get; set; }
        // Müşteri Yorum
        public string CLientImage { get; set; }
        // Müşteri Resim
        public bool Status { get; set; }
    }
}
