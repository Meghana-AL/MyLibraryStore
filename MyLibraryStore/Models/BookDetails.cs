using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Models
{
    public class BookDetails
    {
        [Required]
        [Display(Name = "Book Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Book Name")]
        public string BookName { get; set; }

        [Required]
        [Display(Name ="Author Name")]
        public string Author { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [Display(Name ="Published Date")]
        public DateTime PublishDate { get; set; }
    }
}
