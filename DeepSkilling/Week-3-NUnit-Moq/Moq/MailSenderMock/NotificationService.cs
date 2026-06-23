namespace MoqDemo.MailSenderMock
{
    public class NotificationService
    {
        private readonly IEmailService emailService;

        public NotificationService(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public bool SendWelcomeEmail(string email)
        {
            return emailService.SendEmail(
                email,
                "Welcome",
                "Welcome to our application"
            );
        }
    }
}
