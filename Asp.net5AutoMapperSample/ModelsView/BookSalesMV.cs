
using net5AutoMapperSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspNetCoerRepositoryPattern.ModelsView
{
    public class BookSalesMV
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Book")]
        public int BookId { get; set; }
        [Display(Name = "Book Name")]
        public string BookName { get; set; }

        [Required]
        [Display(Name = "Sale Date")]
        public DateTime Date { get; set; }
        [Required]
        public decimal Price { get; set; }
        public List<Book> Books { get; set; }
    }
}
