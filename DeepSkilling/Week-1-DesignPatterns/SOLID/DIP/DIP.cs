using System;

interface IMessageService
{
    void Send(string message);
}

class EmailService : IMessageService
{
    public void Send(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}

class Notification
{
    private readonly IMessageService messageService;

    public Notification(IMessageService service)
    {
        messageService = service;
    }

    public void Notify(string message)
    {
        messageService.Send(message);
    }
}

class DIP
{
    static void Main()
    {
        IMessageService service = new EmailService();

        Notification notification =
            new Notification(service);

        notification.Notify("Welcome to CTS");
    }
}
