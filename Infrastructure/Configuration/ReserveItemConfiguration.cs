using Domain.entity.Model;
using Domain.entity.Model.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class ReserveItemConfiguration : IEntityTypeConfiguration<ReserveItem>
    {
        public void Configure(EntityTypeBuilder<ReserveItem> builder)
        {
            builder.HasOne(r => r.Customer)
              .WithOne(c => c.Reserve)
              .HasForeignKey<Reserve>(r => r.CustomerId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.User)
               .WithMany(u => u.Reserves)
               .HasForeignKey(r => r.UserId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(c => c.Deposits)
                 .WithOne(i => i.Reserve)
                 .HasForeignKey(i => i.ReserveId)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
