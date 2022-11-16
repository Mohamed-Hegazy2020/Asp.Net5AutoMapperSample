using AutoMapper;
using net5AutoMapperSample.Models;
using net5AutoMapperSample.ModelsView;

namespace Asp.net5AutoMapperSample.AutoMappers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookMV>().ForMember(d=>d.Discount,s=>s.MapFrom(s=>s.Price>= 10? 2:0 )).ReverseMap();
            CreateMap<Author, AuthorMV>().ForMember(d=>d.Auther_Id,s=>s.MapFrom(s=>s.AutherName +"__"+ s.Id)).ReverseMap();
        }
    }
}
