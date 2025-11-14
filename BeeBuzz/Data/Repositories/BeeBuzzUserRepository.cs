using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzUserRepository: BeeBuzzGenericGenericRepository<ApplicationUser>, IBeeBuzzUserRepository
    {
        public BeeBuzzUserRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<ApplicationUser>> logger) : base(db, logger)
        {
            
        }
        //6. Create a repo method to get all the Users for an Organization (3%)
        public IEnumerable<ApplicationUser> GetByCategory(int categoryId)
        {
            return _dbSet.Where(u=> u.organizationId == categoryId).
                ToList();
        }
    }
}
