using Moq;
using NUnit.Framework;
using CustomerCommLib;

namespace CustomerCommLib.Tests;

[TestFixture]
public class CustomerCommTests
{
    [Test]
    public void SendMailToCustomer_ShouldInvokeMailSenderOnce()
    {
        var mockMailSender = new Mock<IMailSender>();

        mockMailSender
            .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(true);

        var customerComm = new CustomerComm(mockMailSender.Object);

        bool result = customerComm.SendMailToCustomer();

        Assert.That(result, Is.True);

        mockMailSender.Verify(
            x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()),
            Times.Once);
    }
}
