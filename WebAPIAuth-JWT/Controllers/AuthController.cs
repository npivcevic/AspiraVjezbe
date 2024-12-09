using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPIAuth_JWT.DTOs;
using WebAPIAuth_JWT.Models;
using WebAPIAuth_JWT.Services;

namespace WebAPIAuth_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static List<User> users = new List<User>()
        {
            new User() { Id = 1, Email = "john@example.com", Password = "abcd" },
            new User() { Id = 2, Email = "anna@example.com", Password = "1234" }
        };

        private readonly TokenService _tokenService;

        public AuthController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<TokenResponse>> Login([FromBody] LoginDTO loginDTO)
        {
            User? user = users.Find(u => u.Email == loginDTO.Email && u.Password == loginDTO.Password);

            if (user == null)
            {
                return Unauthorized("Invalid user credentials.");
            }

            string token = _tokenService.IssueToken(user);
            RefreshToken refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshTokens.Add(refreshToken);

            return Ok(new TokenResponse() {
                AccessToken = token,
                RefreshToken = refreshToken.Value
            });
        }

        [HttpPost("refreshToken")]
        public async Task<ActionResult<TokenResponse>> RefreshToken([FromBody] RefreshTokenRequest refreshTokenRequest)
        {
            User? user = users.Find(u =>
                u.RefreshTokens.Exists(rt =>
                    rt.Value == refreshTokenRequest.RefreshToken
                    && rt.ExpiresAt > DateTime.Now));

            if (user == null)
            {
                return Unauthorized("Invalid refresh token.");
            }

            user.RefreshTokens.RemoveAll(rt => rt.Value == refreshTokenRequest.RefreshToken);

            string token = _tokenService.IssueToken(user);
            RefreshToken refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshTokens.Add(refreshToken);

            return Ok(new TokenResponse()
            {
                AccessToken = token,
                RefreshToken = refreshToken.Value
            });
        }


        [HttpPost("logout")]
        [Authorize]
        public async Task<ActionResult<TokenResponse>> Logout()
        {
            string? UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (UserId == null)
            {
                return Unauthorized("User Id not found in JWT token.");
            }

            int authenticatedUserId = int.Parse(UserId);

            User? user = users.Find(u => u.Id == authenticatedUserId);

            if (user == null)
            {
                return Unauthorized("User not found.");
            }

            user.RefreshTokens = [];

            return NoContent();
        }
    }
}
