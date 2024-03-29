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
using UserProfileAPI.Dto;
using UserProfileAPI.Service;

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
        [SwaggerResponse(statusCode: 200, type: typeof(WishListDto), description: "OK")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorDto), description: "Forbidden")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorDto), description: "Not Found")]
        public async Task<IActionResult> GetWishListId([FromRoute(Name = "id")] string id)
        {

            throw new NotImplementedException();
        }
    }
}
