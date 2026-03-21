using MassTransit;
using Events.Models;

namespace NotificationsAPI.Events.Consumers
{
    public class PaymentProcessedConsumer : IConsumer<PaymentProcessedEvent>
    {
        public Task Consume(ConsumeContext<PaymentProcessedEvent> context)
        {
            var message = context.Message;

            if(message.Status == "Approved")
            {
                Console.WriteLine("================================");
                Console.WriteLine("📧 Email - Pagamento aprovado!");
                Console.WriteLine("================================");
            }else
            {
                Console.WriteLine("================================");
                Console.WriteLine("📧 Email - Pagamento recusado!");
                Console.WriteLine("================================");
            }

            return Task.CompletedTask;
        }
    }
}