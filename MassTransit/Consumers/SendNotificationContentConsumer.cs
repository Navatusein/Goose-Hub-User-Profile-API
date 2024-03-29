using MassTransit;
using System.Reactive;
using UserProfileAPI.MassTransit.Events;
using UserProfileAPI.Models;
using UserProfileAPI.Service.DataServices;

namespace UserProfileAPI.MassTransit.Consumers
{
    /// <summary>
    /// Consumer for SendNotificationContentEvent
    /// </summary>
    public class SendNotificationContentConsumer : IConsumer<SendNotificationContentEvent>
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<SendNotificationContentConsumer>();

        private readonly UserProfileService _dataService;

        /// <summary>
        /// Constructor
        /// </summary>
        public SendNotificationContentConsumer(UserProfileService dataService)
        {
            _dataService = dataService;
        }

        /// <summary>
        /// Consume
        /// </summary>
        public async Task Consume(ConsumeContext<SendNotificationContentEvent> context)
        {
            var message = context.Message;
            var notification = new Models.Notification()
            {
                Message = message.Message,
                LinkRaw = message.LinkRaw
            };

            await _dataService.AddContentNotificationAsync(message.ContentId, notification);
        }
    }
}
