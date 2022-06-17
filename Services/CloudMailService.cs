namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private readonly string mailTo = string.Empty;
        private readonly string mailFrom = string.Empty;

        public CloudMailService(IConfiguration configuration)
        {
            mailTo = configuration["mailSettings:mailToAddress"];
            mailFrom = configuration["mailSettings:MailFromAddress"];
        }

        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {mailFrom} to {mailTo}, with {nameof(CloudMailService)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
