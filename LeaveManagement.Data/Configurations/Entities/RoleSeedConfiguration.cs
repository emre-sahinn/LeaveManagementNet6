using LeaveManagement.Common.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configuration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            //db ye rol ekle
            builder.HasData(new IdentityRole
            {
                Id = "aaaa1111-7294-4091-9482-dcd934b47cd1", //random id verdik
                Name = Roles.Administrator,
                NormalizedName = Roles.Administrator.ToUpper()
            });

            builder.HasData(new IdentityRole
            {
                Id = "aaaa2222-7294-4091-9482-dcd934b47cd1",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper()
            });
        }
    }
}