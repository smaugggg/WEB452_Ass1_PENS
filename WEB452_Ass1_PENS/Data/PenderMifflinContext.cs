using Microsoft.EntityFrameworkCore;
using WEB452_Ass1_PENS.Models;

namespace WEB452_Ass1_PENS.Data {
    public class PenderMifflinContext : DbContext {
        public PenderMifflinContext(DbContextOptions<PenderMifflinContext> options) : base(options) {
        }

        public DbSet<Pen> Pen { get; set; }
    }
}