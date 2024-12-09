# Task

Create a .NET Core Web API project that uses JWT Authentication

- Install NuGet packet `Microsoft.AspNetCore.Authentication.JwtBearer`
- Create the model `User` with properties `Id`, `Email` and `Password`
- In appsettings.json add the configuration:
```
  "Jwt": {
    "Key": "ARandomSecretKeyToSignTheJWTtokens",
    "Issuer": "https://localhost:7207",
    "Audience": "https://localhost:7207"
  }
```
- create a service `TokenService`
	- It requires an `IConfiguration` argument that will be injected using DI
	- Create a method `IssueToken` that takes a User argument and returns a string containing the JWT token
- In program.cs
	- Register the `TokenService` for DI
	- Setup JWT authentication mechanism:
```
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidAudience = builder.Configuration["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                    };
                });
```
- Create the class `LoginDTO` that contains `email` and `password` fields
- Create the class `TokenResponseDTO` that contains `AccessToekn` field
- Create a new controller `AuthController`
    - Requires a TokenService in the constructor
    - Add method POST /login that receives a LoginDTO as argument
        - Verify user exists in a local static List of users
        - If it exists, creat a JWT token and return it to the user
- Add `[Authorize]` to the `WeatherForecast` controller
- Test the app
    - try accessing the WeatherForcast endpoint (should get a 401 status)
    - post valid credentials to the login endpoint
    - using the returned access token try to access the WeatherForcast endpoint

Implement the refresh token:

- Create a class RefreshToken that contains `Id`, `Value` and `ExpiresAt`
- Add a List of RefreshTokens to User class
- In TokenService add method `GenerateRefreshToken` that returns a new RefreshToken
- Update `TokenResponseDTO` to also include a string RefreshToken
- Update `login` method to also create a new refresh token and add it to the user on successfull login
- Create `RefreshTokenRequestDTO` that contains a string `refreshToken`
- In `AuthController` add methods
  - `POST /refreshToken` that accepts a RefreshTokenRequestDTO
    - find the supplied refresh token in the list of users
    - if one is found, issue a new access token
    - delete the existing refresh token and add the newly created one
    - return the `TokenResponseDTO`
  - `POST /logout` 
    - get the user id of the currently logged in user from the JWT claims
    - if user id is found, and a user with that ID is found in the list, delete all their refresh tokens
- Test the new endpoints
   - login
   - try refreshing the token
   - try refreshing the token with the old refresh token
   - try logging out
   - try using the refresh token after logging out

***

# Zadatak

Kreirajte .NET Core Web API projekt koji koristi JWT autentifikaciju.

- Instariamo NuGet paket `Microsoft.AspNetCore.Authentication.JwtBearer`
- Kreirajte model `User` s atributima `Id`, `Email` i `Password`.
- U datoteci `appsettings.json` dodajte konfiguraciju:
```
  "Jwt": {
    "Key": "ARandomSecretKeyToSignTheJWTtokens",
    "Issuer": "https://localhost:7207",
    "Audience": "https://localhost:7207"
  }
```

- Kreirajte servis `TokenService`:
	- Zahtijeva argument `IConfiguration` koji će biti injektiran koristeći DI.
	- Kreirajte metodu `IssueToken` koja prima argument tipa User i vraća string koji sadrži JWT token.
- U datoteci `program.cs`:
	- Registrirajte `TokenService` za DI.
	- Postavite mehanizam JWT autentifikacije:
```
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["Jwt:Issuer"],
                        ValidAudience = builder.Configuration["Jwt:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
                    };
                });
```


- Kreirajte klasu `LoginDTO` koja sadrži polja `email` i `password`.
- Kreirajte klasu `TokenResponseDTO` koja sadrži polje `AccessToken`.
- Kreirajte novi kontroler `AuthController`:
    - Zahtijeva `TokenService` u konstruktoru.
    - Dodajte metodu `POST /login` koja prima `LoginDTO` kao argument.
        - Provjerite postoji li korisnik u lokalnoj statičkoj listi korisnika.
        - Ako postoji, kreirajte JWT token i vratite ga korisniku.
- Dodajte `[Authorize]` na kontroler `WeatherForecast`.
- Testirajte aplikaciju:
    - Pokušajte pristupiti endpointu `WeatherForecast` (trebali biste dobiti status 401).
    - Pošaljite važeće vjerodajnice na endpoint za prijavu.
    - Koristeći vraćeni pristupni token, pokušajte pristupiti endpointu `WeatherForecast`.

Implementirajte refresh token:

- Kreirajte klasu `RefreshToken` koja sadrži `Id`, `Value` i `ExpiresAt`.
- Dodajte listu `RefreshTokens` u klasu `User`.
- U `TokenService` dodajte metodu `GenerateRefreshToken` koja vraća novi `RefreshToken`.
- Ažurirajte `TokenResponseDTO` da uključuje i string `RefreshToken`.
- Ažurirajte metodu `login` da također kreira novi refresh token i dodaje ga korisniku nakon uspješne prijave.
- Kreirajte `RefreshTokenRequestDTO` koji sadrži string `refreshToken`.
- U `AuthController` dodajte metode:
  - `POST /refreshToken`, koja prihvaća `RefreshTokenRequestDTO`:
    - Pronađite predani refresh token u listi korisnika.
    - Ako je pronađen, izdajte novi pristupni token.
    - Obrišite postojeći refresh token i dodajte novi.
    - Vratite `TokenResponseDTO`.
  - `POST /logout`:
    - Dohvatite `user id` trenutno prijavljenog korisnika iz JWT claimova.
    - Ako je `user id` pronađen, a korisnik s tim ID-om postoji u listi, obrišite sve njegove refresh tokene.
- Testirajte nove endpointove:
   - Prijavite se.
   - Pokušajte osvježiti token.
   - Pokušajte osvježiti token koristeći stari refresh token.
   - Pokušajte se odjaviti.
   - Pokušajte koristiti refresh token nakon odjave.
