
using net5AutoMapperSample.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace net5AutoMapperSample.ModelsView
{
    public class BookMV
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<Author> Authors { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
