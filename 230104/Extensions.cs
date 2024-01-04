using _230104.Models;
using _230104.Models.DTOs;

namespace _230104
{
    public static class Extensions
    {
        public static UserDTO AsDTO(this User User)
        {
            return new(User.Id, User.UserName, User.UserEmail, User.Password, User.CreatedTime);
        }

        public static AutoDTO AsDTO(this Auto Auto)
        {
            return new(Auto.Id, Auto.Márka, Auto.Típus, Auto.CreatedTime, Auto.UserId);
        }
    }
}
