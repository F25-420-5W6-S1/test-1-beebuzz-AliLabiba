using BeeBuzz.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.SqlServer.Management.Smo.Wmi;
using System.Text.Json;

namespace BeeBuzz.Data
{
    public class BeeBuzzSeeder
    {
        private readonly ApplicationDbContext _db;

        // Gives access to the project's root folder on the server.
        // Used to read files such as art.json.
        private readonly IWebHostEnvironment _hosting;

        // Manages user roles (Admin, Supervisor, Default).
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public BeeBuzzSeeder(
            ApplicationDbContext db, IWebHostEnvironment hosting,
            RoleManager<IdentityRole<int>> roleManager)
        {
            _db = db;
            _hosting = hosting;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            _db.Database.EnsureCreated();

            //Create roles!
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>("Admin"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Default"));
            }
            SeedBeehivesAsync();
            var Admin = new ApplicationUser()
            {
                Id = 0,
                organizationId = 0000 - 0000 - 0000 - 0000,
                beehives = new List<Beehive>()
                {
                    new Beehive() {
                        Id = 3,
                        Location = "Ile perrot",
                        status = "active",
                        ReasoneOfDeactivation = null,
                        OrganizationId = 0000 - 0000 - 0000 - 0000
                    }
                }
            };
            _db.Users.Add(Admin);

            _db.SaveChanges();
            
        }

        public async Task SeedBeehivesAsync()
        {
            if (!_db.Beehives.Any())
            {
                try
                {
                    var file = Path.Combine(_hosting.ContentRootPath, "Data/Beehive.json");
                    var json = File.ReadAllText(file);

                    //Deserialise the json file into the List of Product class
                    var beehives = JsonSerializer.Deserialize<IEnumerable<Service>>(json);

                    if (beehives != null && beehives.Any())
                    {
                        //Add the new list of products to the database
                        _db.Beehives.AddRange((IEnumerable<Beehive>)beehives);

                        _db.SaveChanges();  //commit changes to the database (make permanent) 

                    }

                }
                catch (Exception ex) 
                {
                    throw;
                
                }
            }
                
        }
    }

}
