﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitLogApi.Models
{
    public class Session
    {
        [Key]
        public int SessionId { get; set; }
        public int ApplUserId { get; set; }
        public DateTime SessionDate { get; set; }
        public int SessionWeight { get; set; }
        public int MilesTraveled { get; set; }
        public int MinutesWorked { get; set; }
        public int CaloriesBurned { get; set; }

        //[ForeignKey("ApplicationUserId")]
        public AppUser AppUser { get; set; }

        public ICollection<SessionType> SessionTypes { get; set; }
    }
}
