using Domain.entity.Model;
using Domain.entity.Model.Item;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(c => c.Items)
                   .WithOne(i => i.Category)
                   .HasForeignKey(i => i.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
