using _230104.Models;
using _230104.Models.DTOs;

namespace _230104.Repositories
{
    public class UserService : UserInterface
    {
        private readonly DBContext dbContext;
        public UserService(DBContext dbContext)
        {

            this.dbContext = dbContext;
        }

        public async Task<User> DeleteById(Guid id)
        {

            var user = dbContext.User.Where(x => x.Id == id).FirstOrDefault();

            dbContext.User.Remove(user);
            await dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<IEnumerable<User>> Get()
        {

            return dbContext.User.ToList();
        }

        public async Task<User> GetById(Guid id)
        {

            var user = dbContext.User.Where(x => x.Id == id).FirstOrDefault();

            return user;
        }

        public async Task<User> Post(CreatedUserDTO createDTO)
        {

            var user = new User
            {

                Id = Guid.NewGuid(),
                UserName = createDTO.UserName,
                UserEmail = createDTO.UserEmail,
                Password = createDTO.Password,
                CreatedTime = DateTime.UtcNow
            };

            await dbContext.User.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<User> Put(Guid id, UpdateUserDTO updateDTO)
        {

            var user = dbContext.User.Where(x => x.Id == id).FirstOrDefault();

            user.UserName = updateDTO.UserName;
            user.UserEmail = updateDTO.UserEmail;
            user.Password = updateDTO.Password;

            await dbContext.SaveChangesAsync();

            return user;
        }
    }
}
