using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL3.Models
{
    public class ReliefProgress
    {
        [Key]
        public int ID { get; set; }
        public int ReliefProgressId { get; set; }

        public string Exercise { get; set; }
        public int Count { get; set; }
        public float Weight { get; set; }
        public DateTime Date { get; set; }
    }
}
