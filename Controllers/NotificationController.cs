using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Data;
using System.Xml.Linq;
using UserProfileAPI.Dto;
using static System.Net.Mime.MediaTypeNames;

namespace UserProfileAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("/api/user-profile-api/v1/notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<NotificationController>();

        /// <summary>
        /// Add notification new content
        /// </summary>
        /// <param name="id">Content id</param> 
        /// <param name="notificationDto"></param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Route("content/{id}")]
        [Authorize(Roles = "Admin")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "OK")]
        public async Task<IActionResult> PostNotificationsContentId([FromRoute(Name = "id")] string id, [FromBody] NotificationDto notificationDto)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Add notification to user
        /// </summary>
        /// <param name="id">User id</param> 
        /// <param name="notificationDto"></param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("user/{id}")]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "OK")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorDto), description: "Not Found")]
        public async Task<IActionResult> PostNotificationsUserId([FromRoute(Name = "id")] string id, [FromBody] NotificationDto notificationDto)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(string));

            // TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorDto));

            throw new NotImplementedException();
        }
    }
}
