using Proj_01.Models.dto;

namespace Proj_01.Data
{
    public static class UserStore
    {
        public static List<UserDTO> users= new List<UserDTO>
        {
            new UserDTO{name="seeta",dob="3rdMarch2001"},
            new UserDTO{name="geeta",dob="6thJune2001"}
        };
    }
}
