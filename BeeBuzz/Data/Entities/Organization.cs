using System.Collections.Generic;

namespace BeeBuzz.Data.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }

        public ICollection<Beehive> beehives { get; set; }
    }
}
