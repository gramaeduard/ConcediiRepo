using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concedii.Models
{
    public class Status
    {       [Key]
        public int StatusId { get; set; }
        public string StatusCerere{ get; set; }
    
        public Cerere Cerere { get; set; }
    }
}
