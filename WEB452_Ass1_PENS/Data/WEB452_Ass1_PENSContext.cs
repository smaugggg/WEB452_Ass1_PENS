using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEB452_Ass1_PENS.Models;

namespace WEB452_Ass1_PENS.Data
{
    public class WEB452_Ass1_PENSContext : DbContext
    {
        public WEB452_Ass1_PENSContext (DbContextOptions<WEB452_Ass1_PENSContext> options)
            : base(options)
        {
        }

        public DbSet<WEB452_Ass1_PENS.Models.Pen> Pen { get; set; }
    }
}
