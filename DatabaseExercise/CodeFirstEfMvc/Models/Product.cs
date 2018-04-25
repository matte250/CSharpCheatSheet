using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;    

namespace CodeFirstEfMvc.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name="Name")]
        [Required(ErrorMessage ="Product name must be specified!")]
        [StringLength(50, ErrorMessage ="Name too long")]
        public string ProductName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Display(Name="Price")]
        [Required(ErrorMessage ="Price must be specified!")]
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }
    }
}