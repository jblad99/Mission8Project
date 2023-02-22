using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8_Project.Models
{
    public class TaskForm
    {
        [Key]
        [Required]
        public int TaskId { get; set; }
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        public int QuadrantId { get; set; }
        public Quadrant Quadrant { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public bool Completed { get; set; }
    }
}
