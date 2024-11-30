
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using WebAPIAuth_Basic.Models;

namespace BasicAuthenticationDemo.Models
{
    public class BasicAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        static List<User> users = new List<User>
        {
            new User(){ Id = 1, Email="john@example.com", Password = "secret", Role = "user" },
            new User(){ Id = 1, Email="anna@example.com", Password = "password", Role = "admin" },
        };

        public BasicAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder) : base(options, logger, encoder)
        {
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Missing Authorization Header");
            }

            User? user;
            try
            {
                if (!AuthenticationHeaderValue.TryParse(Request.Headers["Authorization"], out var authHeader))
                {
                    return AuthenticateResult.Fail("Invalid Authorization Header Format");
                }

                var credentialBytes = Convert.FromBase64String(authHeader.Parameter ?? string.Empty);

                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':', 2);

                if (credentials.Length != 2)
                {
                    return AuthenticateResult.Fail("Invalid Authorization Header Content");
                }

                var username = credentials[0];
                var password = credentials[1];

                user = users.FirstOrDefault(u => u.Email == username && u.Password == password);
            }
            catch (FormatException)
            {
                return AuthenticateResult.Fail("Invalid Base64 Encoding in Authorization Header");
            }
            catch (Exception)
            {
                return AuthenticateResult.Fail("Error Processing Authorization Header");
            }

            if (user == null)
            {
                return AuthenticateResult.Fail("Invalid Username or Password");
            }

            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role),
            };

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }

        protected override async Task HandleChallengeAsync(AuthenticationProperties properties)
        {
            Response.Headers["WWW-Authenticate"] = "Basic realm=\"BasicAuthenticationDemo\", charset=\"UTF-8\"";
            Response.StatusCode = 401;

            await Response.WriteAsync("You need to authenticate to access this resource.");
        }
    }
}
