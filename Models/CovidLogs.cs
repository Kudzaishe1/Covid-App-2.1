using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_App_2._0.Models
{
    public class CovidLogs
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        [ForeignKey("Email")]
        public float Temprature { get; set; }
        public DateTime Date { get; set; }
    }
}
