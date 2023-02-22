using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8_Project.Models
{
    public class Quadrant
    {
        [Key]
        [Required]
        public int QuadrantId { get; set; }
        public string Quadrants { get; set; }
    }
}
