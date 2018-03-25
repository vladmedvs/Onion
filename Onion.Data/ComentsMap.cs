using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Onion.Data
{
    public class ComentsMap
    {
        public ComentsMap(EntityTypeBuilder<Coments>entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.User).IsRequired();
            entityTypeBuilder.Property(t => t.Text).IsRequired();
                
        }
    }
}
