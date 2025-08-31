using MimeKit;
using MimeKit.Utils;
using System.Net;
using System.Net.Mail;

var message = new MimeMessage();

var from = new MailboxAddress("Yaseen", "yaseenkhan.dev@gmail.com");

message.From.Add(from);
var to= new MailboxAddress("Hi there", "myaseen.khan9498360@gmail.com");
message.To.Add(to);

message.Subject= "Test Email from .NET 8";

var bb = new BodyBuilder();

bb.TextBody = "Testing text plain with bodybuilder";

//Third version with embedded image in Html body
var imageEntity = bb.LinkedResources.Add("E:\\SendingEmail\\MailDemo\\me.png");

imageEntity.ContentId = MimeUtils.GenerateMessageId();

var htmlBody= $"""
<p> Testing <b>text Html</b> with bodybuilder</p>

<img src="cid:{imageEntity.ContentId}" alt="My Image"/>
""";

bb.HtmlBody = htmlBody;


//For second: Only Html body
//bb.HtmlBody = "<p>Testing <b>text Html</b> with bodybuilder</p>";


//Second: With attachment
//bb.Attachments.Add("E:\\SendingEmail\\MailDemo\\me.png");



//First:Only text plain
//message.Body= new TextPart(MimeKit.Text.TextFormat.Plain)
//{
//    Text= """
//    Hello, this is a test email sent from a .NET 8 application using MimeKit.

//    Let's give it a try.

//    Regards,
//    Yaseen
//    """
//};

message.Body = bb.ToMessageBody();

using var smtp = new MailKit.Net.Smtp.SmtpClient();

await smtp.ConnectAsync("localhost", 1025);

await smtp.SendAsync(message);

await smtp.DisconnectAsync(true);


Console.WriteLine("Email is Sent!");