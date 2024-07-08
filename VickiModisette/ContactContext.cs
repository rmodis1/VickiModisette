using Microsoft.EntityFrameworkCore;
using VickiModisette.Models;

namespace VickiModisette
{
	public class ContactContext : DbContext
	{
		public ContactContext(DbContextOptions<ContactContext> options)
			: base(options)
		{
		}

		public required DbSet<Contact> Contacts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder) =>
			modelBuilder.Entity<Contact>(entity =>
			{
				entity.ToTable("Contact");
				entity.HasKey(e => e.Id);
				entity.Property(e => e.FirstName).HasColumnName("firstName");
				entity.Property(e => e.LastName).HasColumnName("lastName");
				entity.Property(e => e.Email).HasColumnName("email");
			});
    }
}

