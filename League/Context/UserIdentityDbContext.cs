namespace League
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
	using Auth;
    using Microsoft.EntityFrameworkCore.Design;
    using Domains.Player;
    using Domains.Team;
    using System.Globalization;

    public class UserIdentityDbContext : IdentityDbContext<User>
    {
        //private readonly string connectionString;
        public UserIdentityDbContext(DbContextOptions<UserIdentityDbContext>
                options) : base(options)
        {
        }

        protected UserIdentityDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

			Random rand = new Random();

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(Player).Assembly);
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(Team).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(User).Assembly);

			modelBuilder.Entity<Team>().HasMany<Player>(t => t.players);

			// create 3 teams with their players
			int t_nameCount = TeamStrings.Names.Value.Count();
			int t_logoCount = TeamStrings.Logoes.Value.Count();
			int t_contryCount = TeamStrings.Countries.Value.Count();

			int p_nameCount = PlayerStrings.Names.Value.Count();
			int p_prfileCount = PlayerStrings.ProfielImages.Value.Count();
			int p_contryCount = PlayerStrings.Countries.Value.Count();

			for (int i = 0; i < 3; i++)
			{
				ICollection<Player> _players = new List<Player>{};

				for (int j = 0; j < 11; j++)
				{
					Player p = new Player{
							Id = Guid.NewGuid(),
							Name = PlayerStrings.Names.Value[rand.Next()%p_nameCount],
							number = rand.Next()%100,
							profileImage = PlayerStrings.ProfielImages.Value[rand.Next()%p_prfileCount],
							country = PlayerStrings.Countries.Value[rand.Next()%p_contryCount],
							dob = new DateTime(rand.Next()%40+1990, rand.Next()%11+1, rand.Next()%27 +1)
							};
				    modelBuilder.Entity<Player>().HasData(p);
					_players.Add(p);
				}

			    modelBuilder.Entity<Team>().HasData(new Team{
					Id = Guid.NewGuid(),
					Name = TeamStrings.Names.Value[rand.Next()%t_nameCount],
					logo = TeamStrings.Logoes.Value[rand.Next()%t_logoCount],
					country = TeamStrings.Countries.Value[rand.Next()%t_contryCount],
					coatch = TeamStrings.Names.Value[rand.Next()%t_nameCount],
					//players = _players.ToList(),
					foundatoinDate = new DateTime(rand.Next()%40+1990, rand.Next()%11+1, rand.Next()%27 +1)
				});
			}

			//create sample users
            User admin = new User
            {
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                UserName = Names.Admin.Value,
                NormalizedUserName = Names.Admin.Value.ToUpper(),
                Email = Emails.Admin.Value,
                NormalizedEmail = Emails.Admin.Value.ToUpper(),
            };

            User user = new User
            {
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                UserName = Names.User.Value,
                NormalizedUserName = Names.User.Value.ToUpper(),
                Email = Emails.User.Value,
                NormalizedEmail = Emails.User.Value.ToUpper(),
            };

            IdentityRole userRole = new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Name = Auth.Roles.Admin.Value,
                NormalizedName = Auth.Roles.Admin.Value.ToUpper()
            };

            IdentityRole adminRole = new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Name = Auth.Roles.User.Value,
                NormalizedName = Auth.Roles.User.Value.ToUpper()
            };

            user.PasswordHash = new PasswordHasher<User>().HashPassword(user, Passwords.User.Value);
            admin.PasswordHash = new PasswordHasher<User>().HashPassword(admin, Passwords.Admin.Value);

            modelBuilder.Entity<User>().HasData(user, admin);

            modelBuilder.Entity<IdentityRole>().HasData(userRole, adminRole);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>
                    {
                        UserId = admin.Id,
                        RoleId = adminRole.Id
                    },
                    new IdentityUserRole<string>
                    {
                        UserId = user.Id,
                        RoleId = userRole.Id
                    }
                    );

        }
    }

}
