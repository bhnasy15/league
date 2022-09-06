
namespace League
{

    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.EntityFrameworkCore;

    public class ContextFactory : IDesignTimeDbContextFactory<UserIdentityDbContext>
    {
        public ContextFactory()
        {
        }

        UserIdentityDbContext IDesignTimeDbContextFactory<UserIdentityDbContext>.CreateDbContext(string[] args)
        {
            var opt = new DbContextOptionsBuilder<UserIdentityDbContext>();
			opt.UseMySql("Server=localhost; DataBase=League; UserName=sq; Password=pw",ServerVersion.AutoDetect("Server=localhost; DataBase=League; UserName=sq; Password=pw"));
			return new UserIdentityDbContext(opt.Options);
        }
    }
}

