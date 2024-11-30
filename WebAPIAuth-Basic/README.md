# Task

Create a .NET Core Web API project that uses Basic Authentication

- Create the model `User` with properties `Id`, `Email` and `Password`
- Create the class `BasicAuthHandler` that inherits from ` AuthenticationHandler<AuthenticationSchemeOptions>`
	- override the method `HandleAuthenticateAsync`, implement logic how to pull the username and passowrd form the http header, verify agains a local static list of users, and return a success Authentication ticket if user is found
	- override the method `HandleChallengeAsync` that adds the http response header that indicates that Basic auth is required which prompts the browser to prompt the user to ender a username and password
- Add the authorization service to our Services in Program.cs
- Add the `[Authorize]` data attribute on the `WeatherForcaset` controller
- OPTIONAL:
	- add an additional parameter `Role` to the User model
	- in `HandleAuthenticateAsync` add an additional Claim "Role" and populate it with the users role
	- in the `[Authorize]` data attrubute add that only users with the Admin role can access the WeatherForecast controller

***

# Zadatak

Kreirajte .NET Core Web API projekt koji koristi Basic Authentication

- Kreirajte model `User` s atributima `Id`, `Email` i `Password`
- Kreirajte klasu `BasicAuthHandler` koja nasljeđuje `AuthenticationHandler<AuthenticationSchemeOptions>`
  - nadjačajte metodu `HandleAuthenticateAsync`, implementirajte logiku za dohvaćanje korisničkog imena i lozinke iz HTTP zaglavlja, provjeru prema lokalnoj statičkoj listi korisnika i vraćanje uspješne **Authentication ticket** ako je korisnik pronađen
  - nadjačajte metodu `HandleChallengeAsync` koja dodaje HTTP odgovor sa zaglavljem koje označava da je potrebna Basic autentifikacija, što će uzrokovati da preglednik prikaže dijalog za unos korisničkog imena i lozinke
- Dodajte servis za autorizaciju u `Services` unutar `Program.cs`
- Dodajte `[Authorize]` atribut na `WeatherForecast` kontroler
- OPCIONALNO:
  - dodajte dodatni parametar `Role` u model `User`
  - unutar `HandleAuthenticateAsync` dodajte dodatni **Claim** "Role" i popunite ga korisnikovom rolom
  - u `[Authorize]` atribut dodajte da samo korisnici s Admin rolom mogu pristupiti `WeatherForecast` kontroleru
