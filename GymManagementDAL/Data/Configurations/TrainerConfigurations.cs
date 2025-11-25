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
    internal class TrainerConfigurations : GymUserConfigurations<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(X => X.CreateAt)
                .HasColumnName("HireDate")
                .HasDefaultValueSql("GetDate()");


            //builder.HasMany(T => T.Sessions)
            //       .WithOne(S => S.Trainer)
            //       .HasForeignKey(S => S.TrainerId);

            base.Configure(builder);
        }
    }
}
