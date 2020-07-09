using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concedii.Models
{
    public class Cerere
    {
        [Key]
        public int CerereId { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
