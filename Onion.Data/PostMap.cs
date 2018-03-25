using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Data
{
    public class PostMap
    {
        public PostMap(EntityTypeBuilder<Post> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.UserName);
            entityTypeBuilder.Property(t => t.UserPost);
            entityTypeBuilder.HasOne(t => t.Coments).WithOne(c => c.Post).HasForeignKey<Coments>(x => x.Id);
        }
    }
}
