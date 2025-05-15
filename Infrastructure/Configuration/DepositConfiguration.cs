using Domain.entity.Model;
using Domain.entity.Model.Items;
using Domain.entity.Model.Order;
using Domain.entity.Model.Party;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class DepositConfiguration : IEntityTypeConfiguration<Deposit>
    {
        public void Configure(EntityTypeBuilder<Deposit> builder)
        {

            builder.HasOne(r => r.Reserve)
               .WithMany()
               .HasForeignKey(r => r.ReserveId)
               .OnDelete(DeleteBehavior.Restrict);

            //builder.HasMany(c => c.Customers)
            //       .WithOne(i => i.Party)
            //       .HasForeignKey(i => i.PartyId)
            //       .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
