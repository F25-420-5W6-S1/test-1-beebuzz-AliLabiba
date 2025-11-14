namespace BeeBuzz.Data.Entities
{
    public class Beehive
    {

        public int Id { get; set; }
        public string Location { get; set; }

        public string status { get; set; }
        public string reasoneOfDeactivation { get; set; }

        public int OrganizationId { get; set; }
    }
}
