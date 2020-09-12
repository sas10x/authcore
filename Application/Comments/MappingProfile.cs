using AutoMapper;
using Domain;

namespace Application.Comments
{
    public class MappingProfile : Profile
    {
        public MappingProfile ()
        {
            CreateMap<Comment, CommentDto>()
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.Author.UserName))
                .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.Author.DisplayName));
        }
    }
}