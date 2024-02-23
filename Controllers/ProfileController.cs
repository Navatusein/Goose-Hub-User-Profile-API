using Amazon.Auth.AccessControlPolicy;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using UserProfileAPI.Dto;

namespace UserProfileAPI.Controllers
{
    /// <summary>
    /// Profile Controller
    /// </summary>
    [Route("/api/user-profile-api/v1/profile")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<ProfileController>();

        /// <summary>
        /// Get UserProfile
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserProfileDto), description: "OK")]
        public async Task<IActionResult> GetProfile()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(UserProfileDto));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get UserProfile Preview By Id
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="404">Not Found</response>
        [HttpGet("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(statusCode: 200, type: typeof(UserProfilePreviewDto), description: "OK")]
        [SwaggerResponse(statusCode: 404, type: typeof(UserProfilePreviewDto), description: "OK")]
        public async Task<IActionResult> GetProfileId([FromRoute(Name = "id")] string id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(UserProfileDto));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorDto));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Create UserProfile
        /// </summary>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Authorize(Roles = "Service")]
        [SwaggerResponse(statusCode: 201, type: typeof(string), description: "Created")]
        public async Task<IActionResult> PostProfile()
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(string));

            throw new NotImplementedException();
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
            var userId = User.Claims.First(x => x.Type == "UserId").ToString();

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(UserProfileDto));

            throw new NotImplementedException();
        }
    }
}
