﻿using MassTransit;
using UserProfileAPI.MassTransit.Events;
using UserProfileAPI.Service.DataServices;

namespace UserProfileAPI.MassTransit.Consumers
{
    /// <summary>
    /// Consumer for SendNotificationEvent
    /// </summary>
    public class SendNotificationConsumer: IConsumer<SendNotificationEvent>
    {
        private static Serilog.ILogger Logger => Serilog.Log.ForContext<SendNotificationContentConsumer>();

        private readonly UserProfileService _dataService;

        /// <summary>
        /// Constructor
        /// </summary>
        public SendNotificationConsumer(UserProfileService dataService)
        {
            _dataService = dataService;
        }

        /// <summary>
        /// Consume
        /// </summary>
        public async Task Consume(ConsumeContext<SendNotificationEvent> context)
        {
            var message = context.Message;
            var notification = new Models.Notification()
            {
                Message = message.Message,
                LinkRaw = message.LinkRaw
            };

            await _dataService.AddNotificationAsync(message.UserProfileId, notification);
        }
    }
}
