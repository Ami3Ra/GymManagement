using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementDAL.Data.Configurations
{
    internal class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable(Tb =>
            {
                Tb.HasCheckConstraint("CapacityConstraint", "Capacity between 1 and 25");
                Tb.HasCheckConstraint("EndDateCostraint", "EndDate > StartDate");

                //builder.HasOne(S => S.Category)
                //       .WithMany(C => C.Sessions)
                //       .HasForeignKey(S => S.CategoryId);

                builder.HasOne(S => S.Trainer)
                       .WithMany(T => T.Sessions)
                       .HasForeignKey(S => S.TrainerId);

            });
        }
    }
}
