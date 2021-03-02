using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tweets.Models
{
    public class Smartphone
    {
        [Key]
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public int Performance { get; set; }
        public decimal ScreenSize { get; set; }

        public string HardwareDescription { get; set; }
        public decimal Popularity { get; set; }
    }
}
