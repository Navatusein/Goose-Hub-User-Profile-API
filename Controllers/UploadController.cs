using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using UserProfileAPI.Dtos;
using UserProfileAPI.Service;
using UserProfileAPI.Service.DataServices;

namespace UserProfileAPI.Controllers
{
    /// <summary>
    /// Upload Controller
    /// </summary>
    [Route("v1/upload")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<UploadController>();

        private readonly UserProfileService _dataService;
        private readonly MinioService _minioService;

        /// <summary>
        /// Constructor
        /// </summary>
        public UploadController(UserProfileService dataService, MinioService minioService)
        {
            _dataService = dataService;
            _minioService = minioService;
        }


        /// <summary>
        /// Upload Avatar
        /// </summary>
        /// <param name="uploadDto"></param>
        /// <response code="201">OK</response>
        [HttpPost]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 201, description: "OK")]
        public async Task<IActionResult> UploadAvatar([FromForm] UploadDto uploadDto)
        {
            var userId = User.Claims.First(x => x.Type == "UserId").Value.ToString();
            var model = await _dataService.GetByIdAsync(userId);

            if (model == null)
                return StatusCode(404, new ErrorDto("User not found", "404"));

            if (model.AvatarPath != null)
                await _minioService.RemoveAvatar(model.AvatarPath);

            var avatarPath = await _minioService.UploadAvatar(uploadDto.File);

            await _dataService.AddAvatarAsync(userId, avatarPath);

            return StatusCode(201);
        }

        /// <summary>
        /// Delete Avatar
        /// </summary>
        /// <response code="200">OK</response>
        [HttpDelete]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 200, description: "OK")]
        public async Task<IActionResult> DeleteBanner()
        {
            var userId = User.Claims.First(x => x.Type == "UserId").Value.ToString();

            var model = await _dataService.GetByIdAsync(userId);

            if (model == null)
                return StatusCode(404, new ErrorDto("User not found", "404"));

            if (model.AvatarPath == null)
                return StatusCode(404, new ErrorDto("Avatar not found", "404"));

            await _dataService.RemoveAvatarAsync(userId);
            await _minioService.RemoveAvatar(model.AvatarPath!);

            return StatusCode(200);
        }
    }
}
