using AutoMapper;
using Odws.Models;

public class NoteProfile : Profile
{
    public NoteProfile()
    {
        CreateMap<Note, NoteReadDto>()
        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
        .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
        .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
        .ReverseMap();



        CreateMap<Note, NoteCreateDto>()
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.Name}"))
               .ForMember(dest => dest.Description, opt => opt.MapFrom(src => $"{src.Description}"))
               .ReverseMap();
        CreateMap<Note, NoteUpdateDto>()
         .ForMember(
              dest => dest.Name,
              opt => opt.MapFrom(src => $"{src.Name}")
         )
         .ForMember(
              dest => dest.Description,
              opt => opt.MapFrom(src => $"{src.Description}")
         )
         .ForMember(
              dest => dest.Date,
              opt => opt.MapFrom(src => $"{src.Date}")
         )
         .ReverseMap();
    }
}