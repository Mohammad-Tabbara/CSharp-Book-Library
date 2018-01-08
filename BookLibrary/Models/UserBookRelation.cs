using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookLibrary.Models
{
    public class UserBookRelation
    {
        public int Id { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        public int BookId { get; set; }

    }
}