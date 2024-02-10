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
        /// <summary>
        /// Get UserProfile By Id
        /// </summary>
        /// <param name="id">Profile Id</param>
        /// <response code="200">OK</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(statusCode: 200, type: typeof(UserProfileDto), description: "OK")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorDto), description: "Not Found")]
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
        /// <param name="userProfileDto"></param>
        /// <response code="200">OK</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 200, type: typeof(ErrorDto), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorDto), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorDto), description: "Forbidden")]
        public async Task<IActionResult> PostProfile([FromBody] UserProfileDto userProfileDto)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ErrorDto));
            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ErrorDto));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Update UserProfile
        /// </summary>
        /// <param name="id">Profile Id</param>
        /// <param name="userProfileDto"></param>
        /// <response code="200">OK</response>
        /// <response code="403">Forbidden</response>
        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 200, type: typeof(UserProfileDto), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorDto), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorDto), description: "Forbidden")]
        public async Task<IActionResult> PutProfileId([FromRoute(Name = "id")] string id, [FromBody] UserProfileDto userProfileDto)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(UserProfileDto));
            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ErrorDto));

            throw new NotImplementedException();
        }
    }
}
