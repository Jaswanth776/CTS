using Moq;
using NUnit.Framework;

namespace MoqDemo.MailSenderMock
{
    [TestFixture]
    public class NotificationServiceTests
    {
        [Test]
        public void SendWelcomeEmail_ReturnsTrue()
        {
            var emailMock = new Mock<IEmailService>();

            emailMock
                .Setup(x => x.SendEmail(
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<string>()))
                .Returns(true);

            var service =
                new NotificationService(emailMock.Object);

            bool result =
                service.SendWelcomeEmail("test@example.com");

            Assert.IsTrue(result);

            emailMock.Verify(
                x => x.SendEmail(
                    It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<string>()),
                Times.Once);
        }
    }
}
