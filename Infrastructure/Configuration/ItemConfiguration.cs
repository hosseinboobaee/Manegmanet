using Domain.entity.Model;
using Domain.entity.Model.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {

            builder.HasOne(r => r.Category)
               .WithMany()
               .HasForeignKey(r => r.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
