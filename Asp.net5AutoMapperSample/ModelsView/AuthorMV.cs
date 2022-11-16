
using System.ComponentModel.DataAnnotations;

namespace net5AutoMapperSample.ModelsView
{
    public class AuthorMV
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Auther Name")]
        public string AutherName { get; set; }

        public string Address { get; set; }
        public string Auther_Id { get; set; }

        //public string Auther_Id => AutherName +"_"+ Id;
    }
}
