using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserManagementSystem.Models.Dtos.BaseDtos;

namespace UserManagementSystem.Extensions
{
    public class JwtTokenValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly UserDataDto _userData;
        //  private readonly UserManager<AppDbContext> _userManager;

        public JwtTokenValidationMiddleware(RequestDelegate next, UserDataDto userData)
        {
            _next = next;
            _userData = userData;
            //    _userManager = userManager;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                await AttachUserToContext(context, token);

                var userId = _userData.UserId;

                if (!string.IsNullOrEmpty(userId))
                {
                    var requestedResource = context.Request.Path.Value;
                    // Do something with requestedResource if needed
                }
            }

            await _next(context);
        }

        private async Task AttachUserToContext(HttpContext context, string token)
        {
            try
            {
                if (string.IsNullOrEmpty(token))
                {
                    _userData.SetUserContext(null, null, null);
                    return;
                }

                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,                                                 
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("securityCUFuPiCoETkaptanSECURITYsecurity1923")),
                    ValidateIssuer = true,
                    ValidIssuer = "www.fupico.com",
                    ValidateAudience = true,
                    ValidAudience = "www.fupico.com",
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };

                SecurityToken validatedToken;
                ClaimsPrincipal principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = jwtToken.Claims.First(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;
                var userIP = context.Connection.RemoteIpAddress?.ToString();
                if (userIP == "::1")
                {
                    userIP += " -- " + context.Connection.RemotePort.ToString() + " / " + context.Connection.Id;
                }
                var _userManager = context.RequestServices.GetRequiredService<UserManager<IdentityUser>>();

                var user = await _userManager.FindByIdAsync(userId);

                if (user != null)
                {
                    var roles = await _userManager.GetRolesAsync(user);
                    var roleList = roles.ToList();
                    _userData.SetUserContext(userId, userIP, roleList);
                }
                else
                {
                    _userData.SetUserContext(null, null, null);
                }


            }
            catch (Exception)
            {
                _userData.SetUserContext(null, null, null);
            }
        }
    }
}
