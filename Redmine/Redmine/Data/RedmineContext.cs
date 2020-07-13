using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Redmine.Model;

namespace Redmine.Data
{
    public class RedmineContext : DbContext
    {
        public RedmineContext (DbContextOptions<RedmineContext> options)
            : base(options)
        {
        }

        public DbSet<Redmine.Model.Employee> Employee { get; set; }

        public DbSet<Redmine.Model.Issue> Issue { get; set; }

        public DbSet<Redmine.Model.Project> Project { get; set; }
    }
}
