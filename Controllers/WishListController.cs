using Amazon.Auth.AccessControlPolicy;
using Amazon.SecurityToken.SAML;
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
    /// WishList Controller
    /// </summary>
    [Route("/api/user-profile-api/v1/wish-list")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<WishListController>();

        /// <summary>
        /// Get WishList By Id
        /// </summary>
        /// <param name="id">WishList Id</param> 
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("{id}")]
        [AllowAnonymous]
        [SwaggerResponse(statusCode: 200, type: typeof(WishListDto), description: "OK")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorDto), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorDto), description: "Not Found")]
        public async Task<IActionResult> GetWishListId([FromRoute(Name = "id")] string id)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(WishListDto));
            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ErrorDto));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorDto));

            throw new NotImplementedException();
        }
    }
}
