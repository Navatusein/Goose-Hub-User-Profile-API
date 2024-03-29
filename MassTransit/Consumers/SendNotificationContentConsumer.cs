using MassTransit;
using System.Reactive;
using UserProfileAPI.MassTransit.Events;
using UserProfileAPI.Service;
using UserProfileAPI.Models;

namespace UserProfileAPI.MassTransit.Consumers
{
    /// <summary>
    /// 
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
        /// 
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
