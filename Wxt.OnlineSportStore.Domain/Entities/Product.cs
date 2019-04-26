using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Wxt.OnlineSportStore.Domain.Entities
{
    public class Product
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter product's name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter product's description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please specify product's category")]
        public string Category { get; set; }

        [Required]
        [Range(0.01, 100000, ErrorMessage = "Please enter a positive price for product")]
        public decimal Price { get; set; }
    }
}
