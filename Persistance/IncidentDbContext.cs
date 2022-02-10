using Incident.Modal;
using Microsoft.EntityFrameworkCore;

namespace Incident.Persistance
{
    public class IncidentDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<ECH> ECH { get; set; }
        public DbSet<Forklift> Forklift { get; set; }
        public DbSet<ITV> ITV { get; set; }
        public DbSet<MC> MC { get; set; }
        public DbSet<MHC> MHC { get; set; }
        public DbSet<RS> RS { get; set; }
        public DbSet<RTG> RTG { get; set; }
        public DbSet<ECHCheck> ECHCheck { get; set; }
        public DbSet<ForkliftCheck> ForkliftCheck { get; set; }
        public DbSet<ITVCheck> ITVCheck { get; set; }
        public DbSet<MCCheck> MCCheck { get; set; }
        public DbSet<MHCCheck> MHCCheck { get; set; }
        public DbSet<RSCheck> RSCheck { get; set; }
        public DbSet<RTGCheck> RTGCheck { get; set; }
        public DbSet<SnapShot> SnapShot { get; set; }

        public IncidentDbContext(DbContextOptions<IncidentDbContext> options) :
            base(options)
        {
        }
    }
}