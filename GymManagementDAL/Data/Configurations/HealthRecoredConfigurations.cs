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
    internal class HealthRecoredConfigurations : IEntityTypeConfiguration<HealthRecored>
    {
        public void Configure(EntityTypeBuilder<HealthRecored> builder)
        {
            builder.ToTable("Members").HasKey(X => X.Id);

            builder.HasOne<Member>()
                .WithOne(X => X.HealthRecored)
                .HasForeignKey<HealthRecored>(X => X.Id);

            builder.Ignore(X => X.CreateAt);
        }
    }
}
