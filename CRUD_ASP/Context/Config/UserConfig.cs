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
            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "Babar"
                },
                new User
                {
                    Id = 2,
                    Name = "Céleste"
                }
            );
        }
    }
}
