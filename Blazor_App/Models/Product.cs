using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Blazor_App.Models
{
    public partial class Product
    {
        public int ProductRowId { get; set; }
        [Required(ErrorMessage ="Product Id is Must")]
        public string ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is Must")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Category Name is Must")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Manufacturer is Must")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Description is Must")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Base Price is Must")]
        public int BasePrice { get; set; }

    }
}
