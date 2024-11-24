# Task

Create a Web API with CRUD operations on Users table with the following rules:

- User model contains: `Id`, `Name`, `Email`, `Password`, `PhoneNumber`​
- When reading a list of users, only `Id` & `Name` are returned
- When reading a single user, everything except `Password` is returned
- When creating a user, `Name`, `Email`, `Password` are required, `PhoneNumber`​ is optional
- When updating a user, `Name` is required, `PhoneNumber`​ is optional, other fields cannot be updated
- Add validation for the required fields, email and phone formatting.
- OPTIONAL: Add custom validation for checking the email is unique when creating a new user

***

# Zadatak

Kreirajte Web API s CRUD operacijama na tablici Users s sljedećim pravilima:

- Model korisnika sadrži: `Id`, `Name`, `Email`, `Password`, `PhoneNumber`  
- Prilikom čitanja popisa korisnika, vraćaju se samo `Id` i `Name`  
- Prilikom čitanja pojedinačnog korisnika, vraća se sve osim `Password`  
- Prilikom kreiranja korisnika, `Name`, `Email`, `Password` su obavezni, dok je `PhoneNumber` opcionalan  
- Prilikom ažuriranja korisnika, `Name` je obavezan, `PhoneNumber` je opcionalan, ostala polja se ne mogu ažurirati  
- Dodajte validaciju za obavezna polja, formatiranje emaila i telefona.  
- OPCIONALNO: Dodajte prilagođenu validaciju za provjeru jedinstvenosti emaila prilikom kreiranja novog korisnika​

