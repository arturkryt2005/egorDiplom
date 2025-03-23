using egorDipl.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace egorDipl.Data
{
    public class SponsorsDbContext : DbContext
    {
        public SponsorsDbContext(DbContextOptions<SponsorsDbContext> options) : base(options)
        {
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Cooperation> Cooperation { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<EventStatus> EventStatus { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }
        public DbSet<RequestForCooperation> RequestForCooperation { get; set; }
        public DbSet<RequestStatus> RequestStatus { get; set; }
        public DbSet<StaffRole> StaffRole { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Company>()
                .HasMany(c => c.Events)
                .WithOne(e => e.Organizer)
                .HasForeignKey(e => e.OrganizerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Company>()
                .HasMany(c => c.Cooperations)
                .WithOne(co => co.Organizer)
                .HasForeignKey(co => co.OrganizerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Company>()
                .HasMany(c => c.FeedBacks)
                .WithOne(fb => fb.AboutCompany)
                .HasForeignKey(fb => fb.AboutCompanyId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Company>()
                .HasMany(c => c.RequestsForCooperation)
                .WithOne(rfc => rfc.SenderCompany)
                .HasForeignKey(rfc => rfc.SenderCompanyId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Company>()
                .HasMany(c => c.Users)
                .WithOne(u => u.Company)
                .HasForeignKey(u => u.CompanyId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Cooperation>()
                .HasKey(co => co.Id);

            modelBuilder.Entity<Cooperation>()
                .HasOne(co => co.Sponsor)
                .WithMany()
                .HasForeignKey(co => co.SponsorId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Cooperation>()
                .HasOne(co => co.Event)
                .WithMany(e => e.Cooperations)
                .HasForeignKey(co => co.EventId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Cooperation>()
                .HasOne(co => co.Request)
                .WithMany(rfc => rfc.Cooperations)
                .HasForeignKey(co => co.RequestId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Event>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Sponsor)
                .WithMany()
                .HasForeignKey(e => e.SponsorId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Status)
                .WithMany(es => es.Events)
                .HasForeignKey(e => e.StatusId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<FeedBack>()
                .HasKey(fb => fb.Id);

            modelBuilder.Entity<FeedBack>()
                .HasOne(fb => fb.User)
                .WithMany(u => u.FeedBacks)
                .HasForeignKey(fb => fb.UserId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<RequestForCooperation>()
                .HasKey(rfc => rfc.Id);

            modelBuilder.Entity<RequestForCooperation>()
                .HasOne(rfc => rfc.Status)
                .WithMany(rs => rs.RequestsForCooperation)
                .HasForeignKey(rfc => rfc.StatusId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(sr => sr.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}