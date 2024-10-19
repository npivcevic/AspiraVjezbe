using Delegates_02;


EmailServiceAWSSES emailServiceAWSSES = new EmailServiceAWSSES();
NotificationService notificationService = new NotificationService(emailServiceAWSSES.SendEmail);
notificationService.SendEmailNotification("john@example.com", "Hello!");

EmailServiceSMTP emailServiceSMTP = new EmailServiceSMTP();
notificationService.SendEmail = emailServiceSMTP.SendEmail;
notificationService.SendEmailNotification("john@example.com", "Hello!");














