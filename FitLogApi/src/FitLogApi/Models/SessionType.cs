using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitLogApi.Models
{
    public class SessionType
    {
        [Key]
        public int SessionTypeId { get; set; }
        public int SessionId { get; set; }
        public bool Treadmill { get; set; }
        public bool Bike { get; set; }
        public bool Elliptical { get; set; }

        public Session Session { get; set; }
    }
}
