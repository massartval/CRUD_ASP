using CRUD_ASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUD_ASP.Context.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.BirthDate).IsRequired();
            builder.Property(t => t.Email).IsRequired();
            builder.Property(t => t.Password).IsRequired();
            builder.HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Babar", 
                    LastName = "Leroi",
                    BirthDate = new DateTime(1931,01,01),
                    Email = "Babar@gmail.com",
                    Password = "Babar"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Celeste",
                    LastName = "Lareine",
                    BirthDate = new DateTime(1932,02,02),
                    Email = "Celeste@skynet.be",
                    Password = "Celeste"
                }
            );
        }
    }
}
