using Microsoft.EntityFrameworkCore;
using Mosali.Domaine.Entities;

namespace Mosali.Infrastructure.Data.Context
{
    static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Role>().HasData(new Role
            {
                RoleId = 1,
                RoleName = "Admin"
            }, new Role
            {
                RoleId = 2,
                RoleName = "Gestionnaire"
            }
        
          );



        }
    }
}
