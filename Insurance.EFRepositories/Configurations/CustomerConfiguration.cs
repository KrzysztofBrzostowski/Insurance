using Insurance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.EFRepositories.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Pesel).IsFixedLength().HasMaxLength(11).IsRequired().IsUnicode(false);
        }
    }
}
