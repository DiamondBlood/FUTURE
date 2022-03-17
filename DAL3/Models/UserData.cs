using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL3.Models
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Mail { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public int Height { get; set; }
        public DateTime Date { get; set; }
    }
}
