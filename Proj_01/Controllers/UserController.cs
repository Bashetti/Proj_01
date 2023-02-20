using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Proj_01.Data;
using Proj_01.Models.dto;

namespace Proj_01.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController
    {
        [HttpGet]
        public  List<UserDTO> GetUsers()
        {
            return UserStore.users;
        }
        [HttpGet("name",Name ="GetUserName")]
        public UserDTO GetUserName(string name){
            return UserStore.users.FirstOrDefault(u => u.name == name);
        }
        [HttpGet("dob")]
        public UserDTO GetUserDOB(string dob)
        {
            return UserStore.users.FirstOrDefault(u => u.dob == dob);
        }

        /*[HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<UserDTO> CreateUser([FromBody] UserDTO userDTO)
        {
            if (userDTO == null)
            {
                return BadRequest();
            }
            UserStore.users.Add(userDTO);
            return StatusCode(StatusCodes.Status201Created);
            //return Ok();
        }*/
    }
}
