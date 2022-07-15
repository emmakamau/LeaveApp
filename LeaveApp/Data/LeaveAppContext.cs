using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeaveApp.Models;

namespace LeaveApp.Data
{
    public class LeaveAppContext : DbContext
    {
        public LeaveAppContext (DbContextOptions<LeaveAppContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveApp.Models.Staff> Staff { get; set; } = default!;
    }
}
