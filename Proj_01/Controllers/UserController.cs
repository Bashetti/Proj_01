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
        [HttpGet("name")]
        public UserDTO GetUserName(string name){
            return UserStore.users.FirstOrDefault(u => u.name == name);
        }
        [HttpGet("dob")]
        public UserDTO GetUserDOB(string dob)
        {
            return UserStore.users.FirstOrDefault(u => u.dob == dob);
        }

    }
}
