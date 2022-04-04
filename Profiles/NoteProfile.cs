using AutoMapper;
using Odws.Models;

public class NoteProfile : Profile
{
    public NoteProfile()
    {
        CreateMap<Note, NoteCreateDto>()
               .ForMember(
                   dest => dest.Name,
                   opt => opt.MapFrom(src => $"{src.Name}")
               )
               .ForMember(
                   dest => dest.Description,
                   opt => opt.MapFrom(src => $"{src.Description}")
               );
                CreateMap<NoteCreateDto, Note>()
               .ForMember(
                   dest => dest.Name,
                   opt => opt.MapFrom(src => $"{src.Name}")
               )
               .ForMember(
                   dest => dest.Description,
                   opt => opt.MapFrom(src => $"{src.Description}")
               );
    }
}