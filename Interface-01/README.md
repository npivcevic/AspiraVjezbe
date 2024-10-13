# Task

Create a console app that simulates an email notification service with multiple implementations.​

### IEmailService
- interface with method Send(string email, string message)​

### EmailServiceSMTP
- prints "Sending email to {to} with content {message} through SMTP"​

### EmailServiceAWSSES
- prints "Sending email to {to} with content {message} through AWS SES"​

### NotificationService​
- Requires an IEmailService​
- Has a method SendEmailNotification(email, message)​

***

# Zadatak

Sistem za email notifikacije s više implementacija.​

### IEmailService
- interface s metodom Send(string email, string message)​

### EmailServiceSMTP
- Send ispisuje "Sending email to {to} with content {message} through SMTP"​

### EmailServiceAWSSES
- Send ispisuje "Sending email to {to} with content {message} through AWS SES"​

### NotificationService​
- Traži IEmailService​ u konstruktoru
- Sadrži metodu SendEmailNotification(email, message)​

​
​​​
​

​