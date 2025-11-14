using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class BeeBuzzBeehiveRepository : BeeBuzzGenericGenericRepository<Beehive>, IBeeBuzzBeeHiveRepository
    {


        public BeeBuzzBeehiveRepository(ApplicationDbContext db, ILogger<BeeBuzzGenericGenericRepository<Beehive>> logger) : base(db, logger)
        {

        }
        //7. Create a repo method to get all the Beehives for an Organization (3%) yes
        public IEnumerable<Beehive> GetByOrganization(int organizationId)
        {
            return _dbSet.Where(p=> p.OrganizationId == organizationId)
                .ToList();
        }
    }
}
