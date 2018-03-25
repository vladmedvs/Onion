using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Onion.Data;

namespace Onion.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base (options)
        {

        }
        protected override void OnModelCreating ( ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new PostMap(modelBuilder.Entity<Post>());
            new ComentsMap(modelBuilder.Entity<Coments>());
        }
    }
}
