using AutoMapper;
using Odws.Models;

public class NotesProfile : Profile
{
    public NotesProfile()
    {
        CreateMap<Note, NoteCreateDto>()
        .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name))
        .ForMember(x => x.Description, opt => opt.MapFrom(y => y.Description));
    }
}