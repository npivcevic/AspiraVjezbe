# Task

System for tracking a bank account.

### Account:
- contains the current account balance
- mathod Deposit(decimal amount)
- method Withdraw(decimal amount)
- Methods Deposit and Withdraw throw exceptions if the operation is not able to be executed

### Program
- Initializes the account with balance 0
- Reads from the console (using Console.ReadLine()) one of 3 options: Deposit, Withdraw or Exit
- After Deposit or Withdraw it asks for an amount which needs to be parsed using TryParse
- Catches all exceptions from account operations and prints a user friendly error message

***

# Zadatak

Sustav za vođenje stanja bankovnog računa​

### Account:
- sadrži trenutno stanje računa
- metodu Deposit(decimal amount)
- metodz Withdraw(decimal amount)​
- Metode Deposit i Withdraw bacaju Exception ako nije moguće izvršiti operaciju​

### Program
- Inicijalizira račun s iznosom 0​
- Učitava iz konzole (pomoću Console.ReadLine()) jednu od 3 opcije: Deposit, Withdraw ili Exit​
- Nakon Deposit ili Withdraw traži unos broja kojeg parsira pomoću TryParse​
- Hvata sve exceptione Account operacija i ispisuje user-friendly poruku​