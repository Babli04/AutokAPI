using _230104.Models;
using _230104.Models.DTOs;

namespace _230104.Repositories
{
    public interface UserInterface
    {
        Task<IEnumerable<User>> Get();

        Task<User> GetById(Guid id);

        Task<User> Post(CreatedUserDTO createDTO);

        Task<User> Put(Guid id, UpdateUserDTO updateDTO);

        Task<User> DeleteById(Guid id);
    }
}
