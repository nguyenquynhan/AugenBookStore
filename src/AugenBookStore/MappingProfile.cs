using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AugenBookStore.Common.Dtos;
using AugenBookStore.Repositories.Entities;
using AutoMapper;

namespace AugenBookStore
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.VolumeInfo.Title))
                .ForMember(dest => dest.Authors, opt => opt.MapFrom(src => src.VolumeInfo.Authors))
                .ForMember(dest => dest.PublishedDate, opt => opt.MapFrom(src => src.VolumeInfo.PublishedDate))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.VolumeInfo.Description))
                .ForMember(dest => dest.Thumbnail, opt => opt.MapFrom(src => src.VolumeInfo.ImageLinks.Thumbnail))
                .ForMember(dest => dest.Medium, opt => opt.MapFrom(src => src.VolumeInfo.ImageLinks.Medium))
                .ReverseMap();
        }
    }
}
