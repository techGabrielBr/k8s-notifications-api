using MassTransit;
using Events.Models;

namespace NotificationsAPI.Events.Consumers
{
    public class UserCreatedConsumer : IConsumer<UserCreatedEvent>
    {
        public Task Consume(ConsumeContext<UserCreatedEvent> context)
        {
            var message = context.Message;

            Console.WriteLine("================================");
            Console.WriteLine("📧 Enviando email de boas-vindas");
            Console.WriteLine($"Usuário: {message.Email}");
            Console.WriteLine($"Id: {message.Id}");
            Console.WriteLine("Email enviado com sucesso!");
            Console.WriteLine("================================");

            return Task.CompletedTask;
        }
    }
}
