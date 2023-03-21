using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.AbstractServices;
using DomainLayer;

namespace CleanCoreAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticate _IAuthenticate;
        public AuthenticateController(IAuthenticate IAuthenticate)
        {
            _IAuthenticate = IAuthenticate;
        }

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] Login model)
        {

            var User = _IAuthenticate.AuthenticateUser(model.Username, model.Password);
            // throw new Exception("Exception in Login method");
            if (User == null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
            return Ok(User);
            //else
            //{

            //    var tokenstring = _iJWTGeneration.GenerateJwtToken(User);
            //    var refreshtokenstring = _iJWTGeneration.GenerateRefreshToken(ipAddress());
            //    var response = Ok(new
            //    {
            //        token = tokenstring,
            //        userDetails = User,
            //        refreshtoken = refreshtokenstring.Token,
            //    });

            //    setTokenCookie(refreshtokenstring.Token);
            //    return Ok(response);
            //}


        }
    }
}
