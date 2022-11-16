using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace net5AutoMapperSample.Models
{
    public class Author
    {
        public int Id { get; set; }
      
        public string AutherName { get; set; }

        public string Address { get; set; }

    }
}
