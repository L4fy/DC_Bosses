using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Cards> Cards { get; set; }
        public virtual DbSet<Decks> Decks { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Bosses> Bosses { get; set; }
    }
}