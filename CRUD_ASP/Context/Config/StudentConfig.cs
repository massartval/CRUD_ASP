using CRUD_ASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CRUD_ASP.Context.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("student");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.BirthDate).IsRequired();
            builder.Property(t => t.Email).IsRequired();
            builder.Property(t => t.Password).IsRequired();
            builder.Property(t => t.modulAlreadyCompleted).IsRequired();
            builder.Property(t => t.RegistrationRequest).IsRequired();
            builder.HasData(
                new student
                {
                    Id = 1,
                }

            );
        }
    }
}
