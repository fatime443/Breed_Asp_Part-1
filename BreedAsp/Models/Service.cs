using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BreedAsp.Models
{
    public class Service
    {
        [Key]
        public  int  Id { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
