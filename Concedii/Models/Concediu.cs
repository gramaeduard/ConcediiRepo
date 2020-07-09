using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concedii.Models
{
    public class Concediu
    {    
        [Key]
        public int ConcediuId { get; set; }

        public string TipConcediu { get; set; }
        public DateTime Inceput { get; set; }
        public DateTime Sfarsit { get; set; }
        public int PersonalId { get; set; }
        public Personal Personal { get; set; }
    }
}
