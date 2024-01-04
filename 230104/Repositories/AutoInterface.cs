using _230104.Models;
using _230104.Models.DTOs;

namespace _230104.Repositories
{
    public interface AutoInterface
    {
        Task<IEnumerable<Auto>> Get();

        Task<Auto> GetById(Guid id);

        Task<Auto> Post(CreatedAutoDTO createDTO);

        Task<Auto> Put(Guid id, UpdateAutoDTO updateDTO);

        Task<Auto> DeleteById(Guid id);

        Task<IEnumerable<Auto>> GetUserPosts(Guid id);
    }
}
