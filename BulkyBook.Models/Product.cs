using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBook.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        
        public string Description { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "List Price")]
        public decimal ListPrice { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 1-50")]
        public decimal Price { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 51-100")]
        public decimal Price50 { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 100+")]
        public decimal Price100 { get; set; }

        [ValidateNever]
        public string ImageUrl { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        //[ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

        [Required]
        [Display(Name = "Cover Type")]
        public int CoverTypeId { get; set; }

        //[ForeignKey("CoverTypeId")]
        [ValidateNever]
        public CoverType CoverType { get; set; }
    }
}
