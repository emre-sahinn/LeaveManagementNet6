using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = "aaaa1111-7294-4091-9482-dcd934b47cd1",
                UserId = "e6cd6279-7294-4091-9482-dcd934b47cd1"
            },
            new IdentityUserRole<string>
            {
                RoleId = "aaaa2222-7294-4091-9482-dcd934b47cd1",
                UserId = "e7cd6279-7294-4091-9482-dcd934b47cd1"
            });
        }
    }
}