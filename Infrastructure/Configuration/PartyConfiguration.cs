using Domain.entity.Model;
using Domain.entity.Model.Item;
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
    public class PartyConfiguration : IEntityTypeConfiguration<Party>
    {
        public void Configure(EntityTypeBuilder<Party> builder)
        {
            builder.HasMany(c => c.Users)
                   .WithOne(i => i.Party)
                   .HasForeignKey(i => i.PartyId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.Customers)
                   .WithOne(i => i.Party)
                   .HasForeignKey(i => i.PartyId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
