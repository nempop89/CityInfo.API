namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private readonly string mailTo = string.Empty;
        private readonly string mailFrom = string.Empty;

        public LocalMailService(IConfiguration configuration)
        {
            mailTo = configuration["mailSettings:mailToAddress"];
            mailFrom = configuration["mailSettings:MailFromAddress"];
        }
        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {mailFrom} to {mailTo}, with {nameof(LocalMailService)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
