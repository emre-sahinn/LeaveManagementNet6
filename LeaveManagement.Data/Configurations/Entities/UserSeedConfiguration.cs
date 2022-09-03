using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(new Employee //admin
            {
                Id = "e6cd6279-7294-4091-9482-dcd934b47cd1",
                Email = "emresahin@gmail.com",
                NormalizedEmail = "EMRESAHIN@GMAIL.COM",
                NormalizedUserName = "EMRESAHIN@GMAIL.COM",
                UserName = "emresahin@gmail.com",
                Firstname = "System",
                Lastname = "Admin",
                PasswordHash = hasher.HashPassword(null, "test.123"),
                EmailConfirmed = true
            },
            new Employee //normal user
            {
                Id = "e7cd6279-7294-4091-9482-dcd934b47cd1",
                Email = "user@gmail.com",
                NormalizedEmail = "USER@GMAIL.COM",
                NormalizedUserName = "USER@GMAIL.COM",
                UserName = "user@gmail.com",
                Firstname = "System",
                Lastname = "User",
                PasswordHash = hasher.HashPassword(null, "test.123"),
                EmailConfirmed = true
            });;
        }
    }
}