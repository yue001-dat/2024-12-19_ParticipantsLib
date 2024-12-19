using Microsoft.EntityFrameworkCore;

namespace _2024_12_19_ParticipantsLib
{
	public class ParticipantDbContext : DbContext
	{
		public ParticipantDbContext(DbContextOptions<ParticipantDbContext> options) : base(options)
		{
				
		}

		public DbSet<Participant> Participants { get; set; }
	}
}
