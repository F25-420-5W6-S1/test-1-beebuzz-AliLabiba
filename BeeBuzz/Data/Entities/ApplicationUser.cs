using Microsoft.AspNetCore.Identity;

namespace BeeBuzz.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public List<Beehive> beehives { get; set; }

        public int organizationId { get; set; }
    }
}
