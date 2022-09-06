namespace League
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
	using Auth;
    using Microsoft.EntityFrameworkCore.Design;
    using Domains.Player;
    using Domains.Team;

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

			modelBuilder.ApplyConfigurationsFromAssembly(typeof(Player).Assembly);
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(Team).Assembly);

            modelBuilder.ApplyConfigurationsFromAssembly(
                    typeof(User).Assembly);

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
