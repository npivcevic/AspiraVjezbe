// See https://aka.ms/new-console-template for more information
using Interface_01;


NotificationService notificationService = new NotificationService(new EmailServiceAWSSES());
notificationService.SendEmailNotification("john.doe@example.com", "Hello!");


NotificationService notificationService2 = new NotificationService(new EmailServiceSMTP());
notificationService2.SendEmailNotification("john.doe@example.com", "Hello!");
