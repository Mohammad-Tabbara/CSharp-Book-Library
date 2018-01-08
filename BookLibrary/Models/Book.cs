using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        //[StringLength(20)]
        //[RegularExpression(@"\d{1,20}",ErrorMessage ="Book name is too long, should be shorter than 20 char long.")]
        [Display(Name ="Book Name:")]
        public string BookName { get; set; }
        [Required]
        [Display(Name ="Book Rent Price:")]
        [DataType(DataType.Currency)]
        public decimal RentPrice { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }
    }
}