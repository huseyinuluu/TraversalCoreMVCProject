using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatman.concrete
{
    public class Visit
    {
        public int VisitID { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public string PersonCount { get; set; }
        public DateTime VisitDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
