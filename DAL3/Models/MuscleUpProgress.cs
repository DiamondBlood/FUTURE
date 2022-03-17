using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL3.Models
{
    public class MuscleUpProgress
    {
        [Key]
        public int Id { get; set; }
        public int MuscleUpProgressId { get; set; }
        public string Exercise { get; set; }
        public int Count { get; set; }
        public float Weight { get; set; }
        public DateTime Date { get; set; }
        
    }
}
