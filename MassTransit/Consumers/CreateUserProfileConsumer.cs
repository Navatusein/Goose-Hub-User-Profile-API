using MassTransit;
using UserProfileAPI.MassTransit.Events;
using UserProfileAPI.MassTransit.Responses;
using UserProfileAPI.Models;
using UserProfileAPI.Service.DataServices;

namespace UserProfileAPI.MassTransit.Consumers
{
    /// <summary>
    /// Consumer for CreateUserProfileEvent
    /// </summary>
    public class CreateUserProfileConsumer : IConsumer<CreateUserProfileEvent>
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<CreateUserProfileConsumer>();

        private readonly UserProfileService _dataService;

        /// <summary>
        /// Constructor
        /// </summary>
        public CreateUserProfileConsumer(UserProfileService dataService)
        {
            _dataService = dataService;
        }

        /// <summary>
        /// Consume
        /// </summary>
        public async Task Consume(ConsumeContext<CreateUserProfileEvent> context)
        {
            var message = context.Message;

            var userProfile = new UserProfile()
            {
                AvatarPath = "default.jpg",
                Name = message.Name,
                Email = message.Email,
                WishLists = new List<WishList>(),
                History = new List<History>(),
                Notifications = new List<Notification>(),
            };

            var model = await _dataService.CreateAsync(userProfile);

            var response = new CreateUserProfileResponse()
            {
                UserProfileId = model.Id!
            };

            await context.RespondAsync(response);
        }
    }
}
