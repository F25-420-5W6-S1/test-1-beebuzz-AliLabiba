namespace BeeBuzz.Data.Entities
{
    public class Beehive
    {

        public int Id { get; set; }
        public string Location { get; set; }

        public string status { get; set; }
        public string? ReasoneOfDeactivation { get; set; } = null;

        public int OrganizationId { get; set; }
    }
}
