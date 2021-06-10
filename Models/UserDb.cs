using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Covid_App_2._0.Models
{
    public class UserDb
    {
        [Key]
        public string Email { get; set; }
        public string Name { get; set; }
      
        public string Employee { get; set; }

        public string type { get; set; }
    }
}
