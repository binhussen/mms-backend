using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Identity.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
              new IdentityRole
              {
                  Name = "Admin",
                  NormalizedName = "ADMIN"
              },
              new IdentityRole
              {
                  Name = "StoreMan",
                  NormalizedName = "STOREMAN"
              },
              new IdentityRole
              {
                  Name = "Request",
                  NormalizedName = "REQUEST"
              },
              new IdentityRole
              {
                  Name = "Approve",
                  NormalizedName = "APPROVE"
              },
              new IdentityRole
              {
                  Name = "View",
                  NormalizedName = "VIEW"
              }

            );
        }
    }
}
