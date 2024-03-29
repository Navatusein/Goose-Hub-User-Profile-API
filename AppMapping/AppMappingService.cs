using AutoMapper;
using MongoDB.Bson;
using System.Xml.Linq;
using UserProfileAPI.Dtos;
using UserProfileAPI.Models;
using UserProfileAPI.Service;

namespace UserProfileAPI.AppMapping
{
    /// <summary>
    /// AppMappingService
    /// </summary>
    public class AppMappingService : Profile
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AppMappingService()
        {
            CreateMap<UserProfile, UserProfilePreviewDto>()
                .ForMember(dest => dest.AvatarUrl, opt => opt.MapFrom<ImageUrlResolver, string>(src => src.AvatarPath));

            CreateMap<UserProfile, UserProfileDto>()
                .ForMember(dest => dest.AvatarUrl, opt => opt.MapFrom<ImageUrlResolver, string>(src => src.AvatarPath))
                .ReverseMap();

            CreateMap<WishListContent, WishListContentDto>()
                .ReverseMap();

            CreateMap<History, HistoryDto>()
                .ReverseMap();

            CreateMap<Notification, NotificationDto>()
                .ReverseMap();

            CreateMap<WishList, WishListDto>()
                .ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id ?? ObjectId.GenerateNewId().ToString()));
            ;
        }
    }
}
