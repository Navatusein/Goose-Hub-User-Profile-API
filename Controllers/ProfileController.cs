using Amazon.Auth.AccessControlPolicy;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using UserProfileAPI.Dtos;
using UserProfileAPI.Models;
using System.Net;
using UserProfileAPI.Service.DataServices;

namespace UserProfileAPI.Controllers
{
    /// <summary>
    /// Profile Controller
    /// </summary>
    [Route("v1/profile")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<ProfileController>();

        private readonly IMapper _mapper;
        private readonly UserProfileService _dataService;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProfileController(IMapper mapper, UserProfileService dataService)
        {
            _mapper = mapper;
            _dataService = dataService;
        }

        /// <summary>
        /// Get UserProfile
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserProfileDto), description: "OK")]
        public async Task<IActionResult> GetProfile([FromRoute] string id)
        {
            var userId = User.Claims.First(x => x.Type == "UserId").Value.ToString();

            if (userId != id)
                return StatusCode(403, new ErrorDto("Forbidden", "403"));

            var model = await _dataService.GetByIdAsync(userId);

            if (model == null)
                return StatusCode(404, new ErrorDto("User not found", "404"));

            var dto = _mapper.Map<UserProfileDto>(model);

            return StatusCode(200, dto);

        }

        /// <summary>
        /// Get UserProfile Preview By Ids
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("ids")]
        [AllowAnonymous]
        [SwaggerResponse(statusCode: 200, type: typeof(List<UserProfilePreviewDto>), description: "OK")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorDto), description: "OK")]
        public async Task<IActionResult> GetProfileId([FromBody] List<string> ids)
        {
            var models = await _dataService.GetByIdsAsync(ids);
            var dtos = models.Select(x => _mapper.Map<UserProfilePreviewDto>(x)).ToList();

            return StatusCode(200, dtos);
        }

        /// <summary>
        /// Update UserProfile
        /// </summary>
        /// <param name="userProfileDto"></param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        [HttpPut]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserProfileDto), description: "OK")]
        public async Task<IActionResult> PutProfileId([FromBody] UserProfileDto userProfileDto)
        {
            var userId = User.Claims.First(x => x.Type == "UserId").Value.ToString();

            var model = await _dataService.UpdateAsync(userId, _mapper.Map<UserProfile>(userProfileDto));

            if (model == null)
                return StatusCode(404, new ErrorDto("User not found", "404"));

            var dto = _mapper.Map<UserProfileDto>(model);

            return StatusCode(200, dto);

        }
    }
}