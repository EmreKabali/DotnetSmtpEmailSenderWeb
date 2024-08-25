using System;

namespace EmailTestWebApp.Models;

public class Email
{
    public string UserMail { get; set; }

    public string UserPassword { get; set; }

    public string Host { get; set; }

    public int Port { get; set; }

    public string From { get; set; }


    public string Subject { get; set; }

    public string Body { get; set; }

    public string To { get; set; }
}
