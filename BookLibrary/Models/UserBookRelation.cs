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
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int BookId { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }

    }
}