using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BreedAsp.Models
{
    public class Brands
    {
        [Key]
        public int Id { get; set; }
        public string ImageUrl { get; set; }
    }
}
