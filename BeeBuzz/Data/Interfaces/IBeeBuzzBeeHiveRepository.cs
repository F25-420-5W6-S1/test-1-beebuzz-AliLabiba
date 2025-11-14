using BeeBuzz.Data.Entities;


namespace BeeBuzz.Data.Interfaces
{
    public interface IBeeBuzzBeeHiveRepository : IBeeBuzzGenericRepository<Beehive>
    {
        IEnumerable<Beehive> GetByOrganization(int organizationId);
    }
}
