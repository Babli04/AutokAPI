using _230104.Models;
using _230104.Models.DTOs;

namespace _230104.Repositories
{
    public class AutoService : AutoInterface
    {
        private readonly DBContext dbContext;
        public AutoService(DBContext dbContext)
        {

            this.dbContext = dbContext;
        }

        public async Task<Auto> DeleteById(Guid id)
        {

            var user = dbContext.Auto.Where(x => x.Id == id).FirstOrDefault();

            dbContext.Auto.Remove(user);
            await dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<IEnumerable<Auto>> Get()
        {

            return dbContext.Auto.ToList();
        }

        public async Task<Auto> GetById(Guid id)
        {

            var user = dbContext.Auto.Where(x => x.Id == id).FirstOrDefault();

            return user;
        }

        public async Task<Auto> Post(CreatedAutoDTO createDTO)
        {

            var user = new Auto
            {

                Id = Guid.NewGuid(),
                Márka = createDTO.Márka,
                Típus = createDTO.Típus,
                UserId = createDTO.UserId,
                CreatedTime = DateTime.UtcNow
            };

            await dbContext.Auto.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<Auto> Put(Guid id, UpdateAutoDTO updateDTO)
        {

            var user = dbContext.Auto.Where(x => x.Id == id).FirstOrDefault();

            user.Márka = updateDTO.Márka;
            user.Típus = updateDTO.Típus;

            await dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<IEnumerable<Auto>> GetUserPosts(Guid id)
        {

            var postList = dbContext.Auto.Where(x => x.UserId == id).ToList();

            return postList;
        }
    }
}
