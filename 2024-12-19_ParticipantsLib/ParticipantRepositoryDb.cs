using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_19_ParticipantsLib
{
	public class ParticipantRepositoryDb
	{
		private ParticipantDbContext _context;

		public ParticipantRepositoryDb()
		{
			var optionsBuilder = new DbContextOptionsBuilder<ParticipantDbContext>();
			optionsBuilder.UseSqlServer("Server=tcp:yue001.database.windows.net,1433;Initial Catalog=datamatiker;Persist Security Info=False;User ID=sudo;Password=zRGM9n77@nS;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

			_context = new ParticipantDbContext(optionsBuilder.Options);
		}

		public void TruncateDb()
		{
			_context.Database.ExecuteSqlRaw("TRUNCATE TABLE Participants");
		}

		public List<Participant> GetAll()
		{
			return _context.Participants.ToList();
		}

		public Participant? GetById(int id)
		{
			return _context.Participants.FirstOrDefault(x => x.Id == id);
		}

		public Participant Add(Participant participant)
		{
			participant.validate();

			_context.Participants.Add(participant);
			_context.SaveChanges();

			return participant;
		}

		public Participant? Delete(int id)
		{
			Participant? target = GetById(id);

			if (target == null)
			{
				return null;
			}

			_context.Participants.Remove(target);
			_context.SaveChanges();

			return target;	
		}

	}
}
