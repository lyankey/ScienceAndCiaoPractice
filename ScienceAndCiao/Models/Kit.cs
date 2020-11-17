using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScienceAndCiao.Models
{
    public class Kit
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string ImageUrl { get; set; }
        public int AvailableQuantity { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
        public int LengthMinutes { get; set; }
        [Required]
        public byte BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch Branch { get; set; }
        
       
        //public int Grade { get; set; }
        //public Grade Grade { get; set; }



    }


}