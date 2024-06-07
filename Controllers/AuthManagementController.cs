using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using UniversityRanking.Configuration;
using UniversityRanking.Data;
using UniversityRanking.Models;

namespace UniversityRanking.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthManagementController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly JwtConfig _jwtConfig;

    public AuthManagementController(AppDbContext context, IOptions<JwtConfig> jwtConfig)
    {
        _context = context;
        _jwtConfig = jwtConfig.Value;
    }
    
    private string CreateToken(User user, bool isAccess)
    {
        List<Claim> claims = new List<Claim>()
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(
            isAccess ? _jwtConfig.AccessTokenSecret : _jwtConfig.RefreshTokenSecret));

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: isAccess ? DateTime.UtcNow.AddMinutes(1) : DateTime.UtcNow.AddDays(10),
            signingCredentials: credentials
        );

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }
    
    private bool IsValidToken(string token, bool isAccess)
    {
        var tokenHandler = new JwtSecurityTokenHandler();

        var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(
            isAccess ? _jwtConfig.AccessTokenSecret : _jwtConfig.RefreshTokenSecret));

        var tokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero,
            IssuerSigningKey = key
        };

        try
        {
            _ = tokenHandler.ValidateToken(token, tokenValidationParameters, out _);
            return true;
        }
        catch (SecurityTokenValidationException)
        {
            return false;
        }
    }
    private void SetCookie(string accessToken)
    {
        HttpContext.Response.Cookies.Append("X-Access-Token", accessToken,
            new CookieOptions
            {
                Expires = DateTime.UtcNow.AddDays(30),
                Path = "/api/auth/refresh"
            });
    }

    /*[AllowAnonymous]
    [HttpPost("registration")]
    public async Task<IActionResult> Registration()
    {
        
    }*/
}