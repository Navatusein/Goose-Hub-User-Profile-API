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
    /// History Controller
    /// </summary>
    [Route("/api/user-profile-api/v1/history")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        /// <summary>
        /// Clear History
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        [HttpDelete]
        [Authorize(Roles = "User,Admin")]
        public async Task<IActionResult> DeleteHistory()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete Content From History
        /// </summary>
        /// <param name="contentId">Id of content</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("{contentId}")]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorDto), description: "Not Found")]
        public async Task<IActionResult> DeleteHistoryContentId([FromRoute(Name = "contentId")] string contentId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorDto));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Get History
        /// </summary>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        [HttpGet]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<HistoryDto>), description: "OK")]
        public async Task<IActionResult> GetHistory()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<HistoryDto>));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Add Content To History
        /// </summary>
        /// <param name="contentId">Id of content</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("{contentId}")]
        [Authorize(Roles = "User,Admin")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorDto), description: "Not Found")]
        public async Task<IActionResult> PostHistoryContentId([FromRoute(Name = "contentId")] string contentId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorDto));

            throw new NotImplementedException();
        }
    }
}
