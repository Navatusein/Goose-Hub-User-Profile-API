using Amazon.Auth.AccessControlPolicy;
using Amazon.SecurityToken.SAML;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using UserProfileAPI.Dtos;
using UserProfileAPI.Models;
using UserProfileAPI.Service.DataServices;

namespace UserProfileAPI.Controllers
{
    /// <summary>
    /// WishList Controller
    /// </summary>
    [Route("/v1/wish-list")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<WishListController>();

        private readonly UserProfileService _dataService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        public WishListController(IMapper mapper, UserProfileService dataService)
        {
            _mapper = mapper;
            _dataService = dataService;
        }

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
        [SwaggerResponse(statusCode: 200, type: typeof(WishList), description: "OK")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorDto), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorDto), description: "Not Found")]
        public async Task<IActionResult> GetWishListId([FromRoute(Name = "id")] string id)
        {
            var userId = User.Claims.First(x => x.Type == "UserId").Value.ToString();

            var userProfile = await _dataService.GetUserProfileWishListAsync(id, userId);

            if (userProfile == null)
                return StatusCode(404, new ErrorDto("WishList not found", "404"));

            var wishList = userProfile.WishLists[0];

            if (wishList.IsPrivate && userProfile.Id != userId)
                return StatusCode(403, new ErrorDto("WishList is private", "403"));

            var dto = _mapper.Map<WishListDto>(wishList);

            return StatusCode(200, dto);
        }
    }
}
