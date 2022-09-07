
namespace Auth
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthentication _authentication;

        public AuthenticationController(IAuthentication authentication)
        {
            _authentication = authentication;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync(string userName, string mail, string password)
        {
			RegisterationModel model = new RegisterationModel{UserName = userName, Email = mail, Password = password};
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            AuthenticationModel requstedModel = await _authentication.RegisterAsync(model);

            if (!requstedModel.IsAuthenticated)
                return BadRequest(requstedModel.Message);

            return Created("registered user", requstedModel);
        }

        [HttpPost("Token")]
        public async Task<IActionResult> GetTokenAsync(string mail, string password)
        {
			TokenRequestModel model = new TokenRequestModel{Email = mail, Password = password};
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            AuthenticationModel requstedModel = await _authentication.GetTokenAsync(model);

            if (!requstedModel.IsAuthenticated)
                return BadRequest(requstedModel.Message);

            return Ok(requstedModel);
        }

		[Authorize]
        [HttpDelete("Unregister")]
		public async Task<IActionResult> UnregisterAsync(string mail, string password)
        {
			TokenRequestModel model = new TokenRequestModel{Email = mail, Password = password};
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

			AuthenticationModel requstedModel = await
				_authentication.UnregisterAsync(model);

            return requstedModel.IsAuthenticated ? Ok(requstedModel) : BadRequest(requstedModel);
        }

		[Authorize(Roles = "Admin")]
        [HttpPost("SetRole")]
        public async Task<IActionResult> SetRoleAsync(string mail, string role)
        {
			SetRoleModel model = new SetRoleModel{Email = mail, RoleName = role};
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            string rtn = await _authentication.SetRoleAsync(model);

            if (!string.IsNullOrEmpty(rtn))
                return BadRequest(rtn);

            return Created("registered user", rtn);
        }

		[Authorize(Roles = "Admin")]
		[HttpPost("GetByEmail")]
		public IActionResult GetByEmail([FromBody] string mail){
            return Ok(_authentication.GetByEmail(mail));
		}

		[Authorize(Roles = "Admin")]
		[HttpPost("GetUsers")]
		public IActionResult GetAll(){
            return Ok(_authentication.GetAll());
		}
    }
}
