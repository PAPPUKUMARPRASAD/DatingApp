using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.Entities
{
    public class AppUser
    {
        [Key]
        public int TheId { get; set; }
        public string UserName { get; set; }
    }
}