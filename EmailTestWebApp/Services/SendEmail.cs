using System;
using EmailTestWebApp.Models;
using MailKit.Net.Smtp;
using MimeKit;

namespace EmailTestWebApp.Services;

public static class SendEmail
{
    public static string Send(Email email)
    {
        var response = "Ok";
        var emailMessage = new MimeMessage();
        var fromAddress = new MailboxAddress("John", email.From);

        emailMessage.From.Add(fromAddress);
        emailMessage.To.Add(new MailboxAddress("", email.To));
        emailMessage.Subject = email.Subject;
        emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = email.Body };


        using (var client = new SmtpClient())
        {

            client.Connect(email.Host, email.Port, true);
            //client.AuthenticationMechanisms.Remove("XOAUTH2");
            client.Authenticate(email.UserMail, email.UserPassword);
            client.Send(emailMessage);
            client.Disconnect(true);
            client.Dispose();

        }
        return response;
    }
}
