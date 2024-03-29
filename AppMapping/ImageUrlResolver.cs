using AutoMapper;
using UserProfileAPI.Controllers;
using UserProfileAPI.Dto;
using UserProfileAPI.Models;
using UserProfileAPI.Service;

namespace UserProfileAPI.AppMapping
{
    /// <summary>
    /// UrlResolver
    /// </summary>
    public class ImageUrlResolver : IMemberValueResolver<object, object, string, string>
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<ImageUrlResolver>();

        private readonly MinioService _minioService;

        /// <summary>
        /// Constructor
        /// </summary>
        public ImageUrlResolver(MinioService minioService)
        {
            _minioService = minioService;
        }

        /// <summary>
        /// Resolve
        /// </summary>
        public string Resolve(object source, object destination, string sourceMember, string destMember, ResolutionContext context)
        {
            return _minioService.GetAvatarPresignedUrl(sourceMember).Result;
        }
    }
}
